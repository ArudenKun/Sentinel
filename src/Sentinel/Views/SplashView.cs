using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Sentinel.ViewModels;

namespace Sentinel.Views;

public sealed class SplashView : View<SplashViewModel>
{
    protected override object Build(SplashViewModel vm) =>
        Builders
            .Panel()
            .Children(
                StackPanel()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Spacing(4)
                    .Children(Image()),
                StackPanel()
            );
}
