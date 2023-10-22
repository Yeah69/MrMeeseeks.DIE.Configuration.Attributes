// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedType.Global
namespace MrMeeseeks.DIE.Configuration.Attributes;

/// <summary>
/// Configures a mapping to an invocation description type.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class InvocationDescriptionMappingAttribute : Attribute
{
    public InvocationDescriptionMappingAttribute(Type descriptionType) { }
}
// ReSharper enable UnusedParameter.Local
// ReSharper enable UnusedType.Global