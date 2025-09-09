namespace Sentinel.SourceGenerator.Attributes;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GenerateMarkupBuilderForAssemblyAttribute : Attribute
{
    /// <summary>
    /// Creates attribute to trigger source generator to create extension methods for all controls in the assembly of the specified type
    /// </summary>
    /// <param name="referenceType"></param>
    public GenerateMarkupBuilderForAssemblyAttribute(Type referenceType) { }
}
