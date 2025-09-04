using Avalonia.Controls;
using AvaloniaControlsGenerator.Generators;
using AvaloniaControlsGenerator.Reflectonia;
using Lucide.Avalonia;
using SukiUI.Controls;

if (args.Length > 2)
{
    Console.WriteLine("Usage: Generator <OutputPath>");
    return;
}

var includedAssemblies = new HashSet<string>
{
    "Avalonia.Base",
    "Avalonia.Controls",
    "Avalonia.Desktop",
    // "Avalonia.Controls.ColorPicker",
    // "Avalonia.Controls.ItemsRepeater",
    "Avalonia.Controls.DataGrid",
    // "Avalonia.Controls.TreeDataGrid",
    "SukiUI",
    "Lucide.Avalonia",
};

var excludedClasses = new HashSet<string> { "AboutAvaloniaDialog", "zh_CN" };

var log = new ReflectoniaLog();
var factory = new ReflectoniaFactory(log);

void Generate() =>
    new MainGenerator(factory, log).Generate(
        args[0],
        a =>
        {
            Console.WriteLine($"[Assembly] {a}");
            var name = a.GetName().Name;
            var isAvalonia = name is not null && includedAssemblies.Contains(name);
            return isAvalonia;
        },
        t =>
        {
            // Console.WriteLine($"[Type] {t}");
            if (excludedClasses.Contains(t.Name))
            {
                return false;
            }

            return true;
        }
    );

AppBuilder
    .Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(_ =>
    {
        var __ = new DataGrid();
        var ___ = new BusyArea();
        var ____ = new LucideIcon();
        Generate();
    })
    .SetupWithoutStarting();
