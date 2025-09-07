using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Sentinel.Common.Helpers;

namespace Sentinel;

internal static class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        var builder = BuildAvaloniaApp();

        try
        {
            builder.StartWithClassicDesktopLifetime(args, ShutdownMode.OnMainWindowClose);
        }
        catch (Exception e)
        {
            LogHelper.Error(e, "Global Unhandled Exception");
            throw;
        }
        finally
        {
            if (builder.Instance is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .UseR3(ex => LogHelper.Error(ex, "R3 Unhandled Exception"))
            .UseHotReload()
            .LogToTrace();
}
