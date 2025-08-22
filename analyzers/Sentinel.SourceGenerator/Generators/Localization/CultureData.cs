namespace Sentinel.SourceGenerator.Generators.Localization;

internal class CultureData
{
    public const string InvariantKeyName = "invariant";

    public string Key { get; private set; } = string.Empty;
    public string NormalizedKey { get; private set; } = string.Empty;
    public TranslationData Translations { get; private set; } = new();

    private CultureData() { }

    public static IReadOnlyList<CultureData> Initialize(
        string filePath,
        ITranslationReader translationReader
    )
    {
        var searchDir = Path.GetDirectoryName(filePath)!;
        var fileName = Path.GetFileNameWithoutExtension(filePath);
#pragma warning disable RS1035
        return Directory
            .GetFiles(searchDir, $"{fileName}*{Path.GetExtension(filePath)}")
#pragma warning restore RS1035
            .Select(cfp => ResolveCulture(cfp, translationReader))
            .ToList();
    }

    private static CultureData ResolveCulture(
        string cultureFilePath,
        ITranslationReader translationReader
    )
    {
        var cultureId =
            Path.GetFileNameWithoutExtension(cultureFilePath).Split('_').Skip(1).LastOrDefault()
            ?? InvariantKeyName;

        return new CultureData
        {
            Key = cultureId,
            NormalizedKey = NormalizeCultureIdentifier(cultureId),
            Translations = translationReader.Read(cultureFilePath),
        };
    }

    private static string NormalizeCultureIdentifier(string cultureId) =>
        cultureId.ToLower().Replace('-', '_');
}
