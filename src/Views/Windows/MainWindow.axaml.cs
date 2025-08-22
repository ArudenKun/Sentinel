using Sentinel.ViewModels.Windows;
using Sentinel.Views.Abstractions;

namespace Sentinel.Views.Windows;

public partial class MainWindow : SukiWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
