namespace Sentinel.SourceGenerator.Attributes;

#nullable enable

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class StaticViewLocatorAttribute : Attribute
{
    public StaticViewLocatorAttribute() { }

    public string? ViewToViewModelNamespaceRule { get; set; }
    public string? ViewToViewModelSuffixRule { get; set; }
    public string[]? IncludeNamespaces { get; set; }
    public string[]? ExcludeNamespaces { get; set; }
}
