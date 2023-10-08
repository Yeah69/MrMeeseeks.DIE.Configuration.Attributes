// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedType.Global
namespace MrMeeseeks.DIE.Configuration.Attributes;

/// <summary>
/// Marks a custom (transient) scope.
/// See https://die.mrmeeseeks.dev/scoping/
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class CustomScopeForRootTypesAttribute : Attribute
{
    public CustomScopeForRootTypesAttribute(params Type[] types)
    {
    }
}

/// <summary>
/// Enhances ranges (containers & scopes) by definitions for initialized instances.
/// See https://die.mrmeeseeks.dev/scoping/
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class InitializedInstancesAttribute : Attribute
{
    public InitializedInstancesAttribute(params Type[] types)
    {
    }
}

/// <summary>
/// Marks an user-defined constructor parameters injection method.
/// See https://die.mrmeeseeks.dev/user-defined-elements/
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UserDefinedConstructorParametersInjectionAttribute : Attribute
{
    public UserDefinedConstructorParametersInjectionAttribute(Type type)
    {
    }
}

/// <summary>
/// Marks an user-defined properties injection method.
/// See https://die.mrmeeseeks.dev/user-defined-elements/
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UserDefinedPropertiesInjectionAttribute : Attribute
{
    public UserDefinedPropertiesInjectionAttribute(Type type)
    {
    }
}

/// <summary>
/// Marks an user-defined initializer parameters injection method.
/// See https://die.mrmeeseeks.dev/user-defined-elements/
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UserDefinedInitializerParametersInjectionAttribute : Attribute
{
    public UserDefinedInitializerParametersInjectionAttribute(Type type)
    {
    }
}

/// <summary>
/// Lets you specify which types have an initialization method that should be used during instantiation. Pass the type that owns the initialization method first, then the name of the method. There is one constraint on the method: it must return either nothing (void), a Task, or a ValueTask.
/// See https://die.mrmeeseeks.dev/configuration/miscellaneous/
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class InitializerAttribute : Attribute
{
    public InitializerAttribute(Type type, string methodName)
    {
    }
}

/// <summary>
/// Discards an active initializer method definition. Pass the type that owns the initializer method.
/// See https://die.mrmeeseeks.dev/configuration/miscellaneous/
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FilterInitializerAttribute : Attribute
{
    public FilterInitializerAttribute(Type type)
    {
    }
}

/// <summary>
/// Defines a create function that DIE should create in the container. This attribute defines which classes should be interpreted as containers. Pass first the type to be returned by the create function and then the name to be given to the create function.
/// See https://die.mrmeeseeks.dev/configuration/miscellaneous/
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class CreateFunctionAttribute : Attribute
{
    public CreateFunctionAttribute(Type type, string methodNamePrefix, params Type[] parameterTypes)
    {
    }
}

/// <summary>
/// Intended for internal debugging/testing use only. Will prevent build errors and instead expose the exception.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly)]
public class ErrorDescriptionInsteadOfBuildFailureAttribute : Attribute
{
}

/// <summary>
/// Describes the type of analytics that should be generated.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class AnalyticsAttribute : Attribute
{
    public AnalyticsAttribute(Analytics analytics) { }
}

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
// ReSharper enable UnusedParameter.Local