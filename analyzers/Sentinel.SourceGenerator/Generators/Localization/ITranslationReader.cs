namespace Sentinel.SourceGenerator.Generators.Localization;

internal interface ITranslationReader
{
    TranslationData Read(string filePath);
}
