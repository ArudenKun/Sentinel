using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Sentinel.SourceGenerator.Generators.Localization;

internal class NamesResolver
{
    private readonly AdditionalText _originFile;
    private readonly string _fallBackRootNamespace;
    private readonly AnalyzerConfigOptionsProvider _optionsProvider;

    public NamesResolver(
        AdditionalText originFile,
        string fallBackRootNamespace,
        AnalyzerConfigOptionsProvider optionsProvider
    )
    {
        _originFile = originFile;
        _fallBackRootNamespace = fallBackRootNamespace;
        _optionsProvider = optionsProvider;
    }

    public string ResolveGeneratedClassName()
    {
        if (
            _optionsProvider
                .GetOptions(_originFile)
                .TryGetValue("build_metadata.AdditionalFiles.ClassName", out var className)
            && !string.IsNullOrWhiteSpace(className)
        )
            return className;
        return Path.GetFileNameWithoutExtension(_originFile.Path);
    }

    public string ResolveFileName() => Path.GetFileName(_originFile.Path);

    public string ResolveGeneratedFileName() => $"{ResolveGeneratedClassName()}.g.cs";

    public string ResolveNamespace()
    {
        if (
            _optionsProvider
                .GetOptions(_originFile)
                .TryGetValue("build_metadata.AdditionalFiles.NamespaceName", out var namespaceName)
            && !string.IsNullOrWhiteSpace(namespaceName)
        )
            return namespaceName;

        if (
            !_optionsProvider.GlobalOptions.TryGetValue(
                "build_property.rootnamespace",
                out var rootNamespace
            )
        )
            rootNamespace = _fallBackRootNamespace;

        if (
            _optionsProvider.GlobalOptions.TryGetValue(
                "build_property.projectdir",
                out var projectDir
            )
        )
        {
            var fromPath = EnsurePathEndsWithDirectorySeparator(projectDir);
            var toPath = EnsurePathEndsWithDirectorySeparator(
                Path.GetDirectoryName(_originFile.Path)!
            );
            var relativePath = GetRelativePath(fromPath, toPath);

            return $"{rootNamespace}.{relativePath.Replace(Path.DirectorySeparatorChar, '.')}".TrimEnd(
                '.'
            );
        }

        return rootNamespace;
    }

    private string GetRelativePath(string fromPath, string toPath)
    {
        var relativeUri = new Uri(fromPath).MakeRelativeUri(new(toPath));
        return Uri.UnescapeDataString(relativeUri.ToString())
            .Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
    }

    private string EnsurePathEndsWithDirectorySeparator(string path) =>
        path.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
}
