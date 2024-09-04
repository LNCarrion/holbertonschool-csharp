using System;
using System.Collections.Generic;


/// <summary>
/// The Obj class.
/// </summary>

class Obj
{
    /// <summary>
    /// Checks if the given object is an instance of the Array class or 
    /// a class that inherits from Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of Array or inherits from Array, otherwise False.</returns>

    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
