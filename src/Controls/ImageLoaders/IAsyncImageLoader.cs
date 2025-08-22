using System.Threading.Tasks;
using Avalonia.Media.Imaging;

namespace Sentinel.Controls.ImageLoaders;

public interface IAsyncImageLoader
{
    /// <summary>
    ///     Loads image
    /// </summary>
    /// <param name="url">Target url</param>
    /// <returns>Bitmap</returns>
    public Task<Bitmap?> ProvideImageAsync(string url);
}
