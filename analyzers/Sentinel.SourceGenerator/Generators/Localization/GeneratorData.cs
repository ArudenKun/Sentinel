namespace Sentinel.SourceGenerator.Generators.Localization;

internal class GeneratorData
{
    public required IReadOnlyList<CultureData> CultureData { get; set; }

    public TranslationData InvariantTranslationData =>
        CultureData.Single(cd => cd.Key == Localization.CultureData.InvariantKeyName).Translations;

    public required string Namespace { get; set; }
    public required string GeneratedFileName { get; set; }

    public required string FileName { get; set; }
    public required string GeneratedClassName { get; set; }
}
