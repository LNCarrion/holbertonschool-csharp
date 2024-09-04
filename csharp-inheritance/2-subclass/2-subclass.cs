using System;

/// <summary>
/// The Obj class.
/// </summary>

class Obj
{
    // <summary>
    /// Checks if the specified type is a subclass of the given base type.
    /// The method returns True only if the specified type is a subclass and not the base class itself.
    /// </summary>
    /// <param name="derivedType">The type to check.</param>
    /// <param name="baseType">The base type to compare against.</param>
    /// <returns>True if <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/>, otherwise False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}