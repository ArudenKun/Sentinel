using Microsoft.CodeAnalysis;

namespace Sentinel.SourceGenerator.Generators.Localization;

internal class GeneratorDataBuilder(
    AdditionalText originFile,
    NamesResolver namesResolver,
    ITranslationReader translationReader
)
{
    public GeneratorData Build()
    {
        return new GeneratorData
        {
            GeneratedClassName = namesResolver.ResolveGeneratedClassName(),
            GeneratedFileName = namesResolver.ResolveGeneratedFileName(),
            Namespace = namesResolver.ResolveNamespace(),
            FileName = namesResolver.ResolveFileName(),
            CultureData = CultureData.Initialize(originFile.Path, translationReader),
        };
    }
}
