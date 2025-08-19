using System;
using System.Globalization;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;

namespace Sentinel.Views.Windows;

public partial class ExceptionWindow : Window
{
    public new Window? Owner
    {
        get;
        set
        {
            field = value;

            if (field != null)
            {
                try
                {
                    // Try get title but be care the owner had been disposed.
                    AppName = Dispatcher.UIThread.Invoke(() => field.Title);
                }
                catch
                {
                    // ignored
                }

                try
                {
                    // Try get assembly version but be care the owner class had been unmounted.
                    AppVersion ??= "v" + field.GetType().Assembly.GetName().Version;
                }
                catch
                {
                    // ignored
                }
            }
        }
    }

    public Exception ExceptionObject { get; set; }
    public string ExceptionType => ExceptionObject.GetType().ToString();

    public static readonly StyledProperty<string?> AppNameProperty = AvaloniaProperty.Register<
        ExceptionWindow,
        string?
    >(nameof(AppName));

    public string? AppName
    {
        get => GetValue(AppNameProperty);
        set => SetValue(AppNameProperty, value);
    }

    public static readonly StyledProperty<string?> AppVersionProperty = AvaloniaProperty.Register<
        ExceptionWindow,
        string?
    >(nameof(AppVersion));

    public string? AppVersion
    {
        get => GetValue(AppVersionProperty);
        set => SetValue(AppVersionProperty, value);
    }

    public string ErrorTime { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);

    public string OSVersion { get; } = "Windows " + Environment.OSVersion;

    public ExceptionWindow(Exception? e, string? appName = null, string? appVersion = null)
    {
        ExceptionObject = e ?? new Exception("<NULL>");
        AppName = appName;
        AppVersion = appVersion;

        DataContext = this;
        InitializeComponent();

        Title = "Ttile";
        Hint1TextBlock.Text = "Hint1";
        Hint2TextBlock.Text = "Hint2";
        CopyTextBlock.Text = "Copy";
        IgnoreTextBlock.Text = "Ignore";
        ExitTextBlock.Text = "Exit";

        CopyButton.Click += (_, _) => CopyInfo();
        TryIgnoreButton.Click += (_, _) => IgnoreAndTry();
        ExitButton.Click += (_, _) => ExitApp();
    }

    public string GetInfo()
    {
        StringBuilder sb = new();

        sb.AppendLine($"{AppName} {AppVersion}")
            .AppendLine($"{ErrorTime} {OSVersion}")
            .AppendLine("```")
            .AppendLine(ExceptionObject?.ToString())
            .AppendLine("```");

        return sb.ToString();
    }

    public void CopyInfo()
    {
        try
        {
            Dispatcher.UIThread.Post(() => Clipboard?.SetTextAsync(GetInfo()));
        }
        catch
        {
            // ignored
        }
    }

    public void IgnoreAndTry()
    {
        Close();
    }

    public void ExitApp()
    {
        IgnoreAndTry();
        Environment.Exit('e' + 'x' + 'c' + 'e' + 'p' + 't' + 'i' + 'o' + 'n');
    }
}
