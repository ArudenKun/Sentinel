using System;
using System.IO;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Microsoft.Extensions.Logging;
using Replicant;
using Sentinel.Controls.ImageLoaders;
using Sentinel.Dependency;

namespace Sentinel.Services;

public sealed class HttpCacheImageLoader : IAsyncImageLoader, ISingletonDependency
{
    private readonly IHttpCache _httpCache;
    private readonly ILogger<HttpCacheImageLoader> _logger;

    public HttpCacheImageLoader(IHttpCache httpCache, ILogger<HttpCacheImageLoader> logger)
    {
        _httpCache = httpCache;
        _logger = logger;
    }

    public async Task<Bitmap?> ProvideImageAsync(string url) => await LoadAsync(url);

    private async Task<Bitmap?> LoadAsync(string url)
    {
        var internalOrCachedBitmap =
            await LoadFromLocalAsync(url).ConfigureAwait(false)
            ?? await LoadFromInternalAsync(url).ConfigureAwait(false);
        if (internalOrCachedBitmap != null)
            return internalOrCachedBitmap;

        try
        {
            await using var stream = await _httpCache.StreamAsync(url).ConfigureAwait(false);
            var bitmap = new Bitmap(stream);
            return bitmap;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to resolve image: {RequestUri}", url);

            return null;
        }
    }

    /// <summary>
    /// the url maybe is local file url,so if file exists ,we got a Bitmap
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static Task<Bitmap?> LoadFromLocalAsync(string url) =>
        Task.FromResult(File.Exists(url) ? new Bitmap(url) : null);

    /// <summary>
    ///     Receives image bytes from an internal source (for example, from the disk).
    ///     This data will be NOT cached globally (because it is assumed that it is already in internal source us and does not
    ///     require global caching)
    /// </summary>
    /// <param name="url">Target url</param>
    /// <returns>Bitmap</returns>
    private Task<Bitmap?> LoadFromInternalAsync(string url)
    {
        try
        {
            var uri = url.StartsWith('/')
                ? new Uri(url, UriKind.Relative)
                : new Uri(url, UriKind.RelativeOrAbsolute);

            if (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)
                return Task.FromResult<Bitmap?>(null);

            if (uri is { IsAbsoluteUri: true, IsFile: true })
                return Task.FromResult<Bitmap?>(new Bitmap(uri.LocalPath));

            return Task.FromResult(new Bitmap(AssetLoader.Open(uri)))!;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to resolve image from request with uri: {RequestUri}", url);
            return Task.FromResult<Bitmap?>(null);
        }
    }
}
