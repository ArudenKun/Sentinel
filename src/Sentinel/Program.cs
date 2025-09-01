using Microsoft.Extensions.Hosting;
using Mvvm.Navigation;
using Sentinel.Views;
using Wpf.Hosting;

namespace Sentinel;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder
            .AddMvvmNavigation()
            .AddWpfHost<App, MainWindow>()
            .AddSingleInstance("5E476D26-6CE2-4F97-BB78-1036BB6D28C7");

        var app = builder.Build();
        try
        {
            app.Run();
        }
        catch (Exception e)
        {
            throw;
        }
        finally
        {
            app.Dispose();
        }
    }
}
