using Microsoft.CodeAnalysis;

namespace Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

public class PropertyExtensionInfo : IMemberExtensionInfo
{
    public ITypeSymbol ControlType { get; }
    public string ControlTypeName { get; }
    public string ExtensionName { get; protected set; }
    public string MemberName { get; }
    public ITypeSymbol ValueType { get; }
    public object ValueTypeSource { get; }
    public bool IsGeneric { get; }
    public bool IsAttachedProperty { get; set; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";
    public string? Comment { get; set; }

    public PropertyExtensionInfo(IFieldSymbol field)
    {
        Comment = field.GetDocumentation();

        ControlType =
            field.ContainingType
            ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.Name.RemoveTrailingProperty();
        MemberName = field.Name.RemoveTrailingProperty();

        if (field.AssociatedSymbol != null)
        {
            ExtensionName = field.AssociatedSymbol.Name.RemoveTrailingProperty();
            MemberName = field.AssociatedSymbol.Name.RemoveTrailingProperty();
        }

        ValueType =
            field.Type.TypeKind == TypeKind.Delegate
                ? field.Type
                : field.Type.GetLastGenericArgument();
        ControlTypeName = ControlType.GetFullTypeName();
        ValueTypeSource = ValueType.GetFullTypeName();

        IsAttachedProperty = field.Type.Name.StartsWith("AttachedProperty");
        IsGeneric = !ControlType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $" where T : {ControlTypeName}";
            GenericArg = "<T>";

            if (ControlType is INamedTypeSymbol ct2)
            {
                if (ct2.TypeArguments.Length > 0)
                {
                    GenericConstraint +=
                        " "
                        + ct2.TypeArguments.Select(x => $"where {x.Name} : class")
                            .Aggregate((x, y) => x + ", " + y);
                    GenericArg =
                        "<T, "
                        + ct2.TypeArguments.Select(x => x.Name).Aggregate((x, y) => x + ", " + y)
                        + ">";
                }
            }
        }
    }

    public PropertyExtensionInfo(IPropertySymbol property)
    {
        ControlType =
            property.ContainingType
            ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = property.Name.RemoveTrailingProperty();
        MemberName = property.Name.RemoveTrailingProperty();
        Comment = property.GetDocumentation();

        ValueType =
            property.Type.TypeKind == TypeKind.Delegate
                ? property.Type
                : property.Type.GetLastGenericArgument();
        ControlTypeName = ControlType.GetFullTypeName();
        ValueTypeSource = ValueType.GetFullTypeName();

        IsAttachedProperty = property.Type.Name.StartsWith("AttachedProperty");
        IsGeneric = !ControlType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $" where T : {ControlTypeName}";
            GenericArg = "<T>";

            if (ControlType is INamedTypeSymbol ct2)
            {
                if (ct2.TypeArguments.Length > 0)
                {
                    GenericConstraint +=
                        " "
                        + ct2.TypeArguments.Select(x => $"where {x.Name} : class")
                            .Aggregate((x, y) => x + ", " + y);
                    GenericArg =
                        "<T, "
                        + ct2.TypeArguments.Select(x => x.Name).Aggregate((x, y) => x + ", " + y)
                        + ">";
                }
            }
        }
    }
}
