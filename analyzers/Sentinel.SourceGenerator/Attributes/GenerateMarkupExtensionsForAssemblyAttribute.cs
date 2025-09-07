namespace Sentinel.SourceGenerator.Attributes;

/// <summary>
/// Attribute to trigger source generator to create extension methods for all controls in the assembly of the specified type
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GenerateMarkupExtensionsForAssemblyAttribute : Attribute
{
    /// <summary>
    /// Creates attribute to trigger source generator to create extension methods for all controls in the assembly of the specified type
    /// </summary>
    /// <param name="referenceType"></param>
    public GenerateMarkupExtensionsForAssemblyAttribute(Type referenceType) { }
}
