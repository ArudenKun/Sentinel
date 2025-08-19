using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Wpf.Ui.Controls;

namespace Sentinel.Views.Windows;

public partial class ExceptionWindow
{
    /// <summary>
    /// For safety only use `Application.Current.Dispatcher` for show dialog.
    /// It means the temporary STA thread will be skipped.
    /// </summary>
    public static bool IsOnlyApplicationDispatcher { get; set; } = true;

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
                    AppName ??= field.Dispatcher.Invoke(() => field.Title);
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

    public Exception? ExceptionObject { get; set; }
    public string? ExceptionType => ExceptionObject?.GetType().ToString();

    public string? AppName
    {
        get => (string)GetValue(AppNameProperty);
        set => SetValue(AppNameProperty, value);
    }

    public static readonly DependencyProperty AppNameProperty = DependencyProperty.Register(
        nameof(AppName),
        typeof(string),
        typeof(ExceptionWindow),
        new PropertyMetadata(null)
    );

    public string? AppVersion
    {
        get => (string)GetValue(AppVersionProperty);
        set => SetValue(AppVersionProperty, value);
    }

    public static readonly DependencyProperty AppVersionProperty = DependencyProperty.Register(
        nameof(AppVersion),
        typeof(string),
        typeof(ExceptionWindow),
        new PropertyMetadata(null)
    );

    public string ErrorTime { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);

    // ReSharper disable once InconsistentNaming
    public string OSVersion { get; } =
        Vanara.PInvoke.NtDll.RtlGetVersion(out var osv) == 0
            ? new Version(
                (int)osv.dwMajorVersion,
                (int)osv.dwMinorVersion,
                (int)osv.dwBuildNumber,
                (int)osv.dwPlatformId
            ).ToString()
            : Environment.OSVersion.Version.ToString(); //NTdll.GetOSVersion().ToString();

    public ExceptionWindow(Exception? e, string? appName = null, string? appVersion = null)
    {
        ExceptionObject = e ?? new Exception("<NULL>");
        AppName = appName;
        AppVersion = appVersion;

        DataContext = this;
        InitializeComponent();

        Title = "Error Occured";
        Hint1TextBlock.Text = "Exception Raised";
        Hint2TextBlock.Text =
            "You can copy the info to track the problem, ignore and try, or exit the program and restart.";
        CopyTextBlock.Text = "Copy";
        IgnoreTextBlock.Text = "Ignore";
        ExitTextBlock.Text = "Exit";

        CopyButton.Click += (_, _) => CopyInfo();
        TryIgnoreButton.Click += (_, _) => IgnoreAndTry();
        ExitButton.Click += (_, _) => ExitApp();

        KeyDown += (_, keyEventArgs) =>
        {
            if (
                (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control
                && keyEventArgs.Key == Key.C
            )
            {
                CopyInfo();
            }
        };
    }

    protected override void OnSourceInitialized(EventArgs e)
    {
        base.OnSourceInitialized(e);

        if (WindowBackdrop.IsSupported(WindowBackdropType.Mica))
        {
            Background = new SolidColorBrush(Colors.Transparent);
            WindowBackdrop.ApplyBackdrop(this, WindowBackdropType.Mica);
        }
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
            Clipboard.SetText(GetInfo());
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

    public static void Show(Exception e, string? appName = null, string? appVersion = null)
    {
        Window? owner =
            Application.Current.Windows.OfType<Window>().FirstOrDefault(window => window.IsActive)
            ?? Application.Current.MainWindow;

        Dispatcher dispatcher = Application.Current.Dispatcher;

        if (!IsOnlyApplicationDispatcher)
        {
            dispatcher = owner?.Dispatcher ?? Application.Current.Dispatcher;
        }

        _ = dispatcher.Invoke(() =>
            _ = new ExceptionWindow(e, appName, appVersion) { Owner = owner }.ShowDialog()
        );
    }

    public static async Task ShowAsync(
        Exception e,
        string? appName = null,
        string? appVersion = null
    )
    {
        Window? owner =
            Application.Current.Windows.OfType<Window>().FirstOrDefault(window => window.IsActive)
            ?? Application.Current.MainWindow;

        Dispatcher dispatcher = Application.Current.Dispatcher;

        if (!IsOnlyApplicationDispatcher)
        {
            dispatcher = owner?.Dispatcher ?? Application.Current.Dispatcher;
        }

        await dispatcher.BeginInvoke(() =>
            _ = new ExceptionWindow(e, appName, appVersion) { Owner = owner }.ShowDialog()
        );
    }
}
