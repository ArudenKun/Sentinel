using Avalonia.Markup.Declarative;
using Sentinel.ViewModels.Pages;
using static Avalonia.Markup.Declarative.Builders;

namespace Sentinel.Views.Pages;

public sealed class HomePage : View<HomePageViewModel>
{
    protected override object Build(HomePageViewModel vm)
    {
        return TextBlock().Text("Home Page");
    }
}
