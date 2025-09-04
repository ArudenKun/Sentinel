using System.Text;
using Microsoft.CodeAnalysis;
using Sentinel.SourceGenerator.Common.Extensions;

namespace Sentinel.SourceGenerator.Common;

internal sealed class SourceStringBuilder
{
    private readonly StringBuilder _sourceBuilder = new();
    private readonly StringBuilder _indentPrefix = new();
    private readonly ITypeSymbol _typeSymbol;

    public SourceStringBuilder(ITypeSymbol typeSymbol)
    {
        _typeSymbol = typeSymbol;
    }

    public SourceStringBuilder(IMethodSymbol methodSymbol)
    {
        _typeSymbol = methodSymbol.ContainingType;
    }

    public void Line(params string[] parts)
    {
        if (parts.Length != 0)
        {
            _sourceBuilder.Append(_indentPrefix);

            foreach (var s in parts)
                _sourceBuilder.Append(s);
        }

        _sourceBuilder.AppendLine();
    }

    public void Line(string line)
    {
        Line(parts: line);
    }

    public void BlockTab(Action writeInner)
    {
        BlockPrefix("\t", writeInner);
    }

    public void BlockPrefix(string delimiter, Action writeInner)
    {
        _indentPrefix.Append(delimiter);
        writeInner();
        _indentPrefix.Remove(_indentPrefix.Length - delimiter.Length, delimiter.Length);
    }

    public void BlockBrace(Action writeInner)
    {
        Line("{");
        BlockTab(writeInner);
        Line("}");
    }

    public void BlockDecl(Action writeInner)
    {
        Line("{");
        BlockTab(writeInner);
        Line("};");
    }

    public void NamespaceBlockBrace(Action writeInner)
    {
        Line("namespace ", _typeSymbol.NamespaceOrEmpty());
        BlockBrace(writeInner);
    }

    public void NamespaceBlockBrace(string nameSpace, Action writeInner)
    {
        Line("namespace ", nameSpace);
        BlockBrace(writeInner);
    }

    public void PartialTypeBlockBrace(Action writeInner)
    {
        var type =
            _typeSymbol.IsRecord ? "record"
            : _typeSymbol.IsValueType ? "struct"
            : "class";
        NamespaceBlockBrace(() =>
        {
            Line($"partial {type} {_typeSymbol.Name}");
            BlockBrace(writeInner);
        });
    }

    public void PartialTypeBlockBrace(string baseClassesOrImplementations, Action writeInner)
    {
        var type =
            _typeSymbol.IsRecord ? "record"
            : _typeSymbol.IsValueType ? "struct"
            : "class";

        NamespaceBlockBrace(() =>
        {
            Line($"partial {type} {_typeSymbol.Name} : {baseClassesOrImplementations}");
            BlockBrace(writeInner);
        });
    }

    public void Constructor(string[] args, Action writeInner)
    {
        var arguments = string.Join(", ", args);
        Line($"public {_typeSymbol.Name}({arguments})");
        BlockBrace(writeInner);
    }

    public void Constructor(string args, Action writeInner)
    {
        Line($"public {_typeSymbol.Name}({args})");
        BlockBrace(writeInner);
    }

    public void Constructor(Action writeInner)
    {
        Line($"public {_typeSymbol.Name}()");
        BlockBrace(writeInner);
    }

    public override string ToString()
    {
        return _sourceBuilder
            + "\n"
            + "/*"
            + "\n"
            + "---- END OF GENERATED SOURCE TEXT ----"
            + "\n"
            + "Roslyn doesn't clear the file when writing debug output for"
            + "\n"
            + "EmitCompilerGeneratedFiles, so I'm writing this message to"
            + "\n"
            + "make it more obvious what's going on when that happens."
            + "\n"
            + "*/"
            + "\n";
    }
}
