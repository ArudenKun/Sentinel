using Microsoft.CodeAnalysis;

namespace Sentinel.SourceGenerator.Generators.Localization;

[Generator]
public sealed class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var jsonFiles = context.AdditionalTextsProvider.Where(file =>
            file.Path.EndsWith(".json", StringComparison.OrdinalIgnoreCase)
        );

        var provider = jsonFiles
            .Combine(context.CompilationProvider)
            .Combine(context.AnalyzerConfigOptionsProvider);

        context.RegisterSourceOutput(
            provider,
            (spc, tuple) =>
            {
                var (innerTuple, options) = tuple;
                var (additionalText, compilation) = innerTuple;

                var translationReader = new JsonTranslationReader(spc.ReportDiagnostic);
                var codeGenerator = new LocalizeCodeGeneratorCore();

                var namesResolver = new NamesResolver(
                    additionalText,
                    compilation.AssemblyName ?? "Assembly",
                    options
                );

                var ctx = new GeneratorDataBuilder(
                    additionalText,
                    namesResolver,
                    translationReader
                ).Build();

                spc.AddSource(ctx.GeneratedFileName, codeGenerator.CreateClass(ctx));
            }
        );
    }
}
