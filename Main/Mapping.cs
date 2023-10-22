// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedType.Global
namespace MrMeeseeks.DIE.Configuration.Attributes;

/// <summary>
/// Configures a mapping to an attribute which assigns a key to an implementation type.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class InjectionKeyMappingAttribute : Attribute
{
    public InjectionKeyMappingAttribute(Type attributeType) { }
}

/// <summary>
/// Filters a mapping to an attribute which assigns a key to an implementation type.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FilterInjectionKeyMappingAttribute : Attribute
{
    public FilterInjectionKeyMappingAttribute(Type attributeType) { }
}

/// <summary>
/// Configures a mapping to an attribute which assigns a decoration ordinal to a decoration implementation.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class DecorationOrdinalMappingAttribute : Attribute
{
    public DecorationOrdinalMappingAttribute(Type attributeType) { }
}

/// <summary>
/// Filters a mapping to an attribute which assigns a decoration ordinal to a decoration implementation.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FilterDecorationOrdinalMappingAttribute : Attribute
{
    public FilterDecorationOrdinalMappingAttribute(Type attributeType) { }
}

/// <summary>
/// Configures a mapping to an invocation description type.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class InvocationDescriptionMappingAttribute : Attribute
{
    public InvocationDescriptionMappingAttribute(Type descriptionType) { }
}

/// <summary>
/// Configures a mapping to an type description type.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class TypeDescriptionMappingAttribute : Attribute
{
    public TypeDescriptionMappingAttribute(Type descriptionType) { }
}

/// <summary>
/// Configures a mapping to an method description type.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class MethodDescriptionMappingAttribute : Attribute
{
    public MethodDescriptionMappingAttribute(Type descriptionType) { }
}
// ReSharper enable UnusedParameter.Local
// ReSharper enable UnusedType.Global