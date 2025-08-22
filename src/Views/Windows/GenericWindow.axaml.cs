using System;
using Avalonia.Controls;

namespace Sentinel.Views.Windows;

public partial class GenericWindow : Window
{
    public GenericWindow()
    {
        InitializeComponent();
    }

    protected override void OnClosed(EventArgs e)
    {
        if (DataContext is IDisposable disposable)
        {
            disposable.Dispose();
        }

        base.OnClosed(e);
    }
}
