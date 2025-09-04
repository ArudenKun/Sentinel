namespace Sentinel.SourceGenerator.Common;

internal sealed record DiagnosticDetail(string Id, string Category, string Title, string Message)
{
    public static readonly DiagnosticDetail Empty = new(
        "Empty",
        string.Empty,
        string.Empty,
        string.Empty
    );
}
