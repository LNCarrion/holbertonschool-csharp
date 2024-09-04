using System;
using System.Collections.Generic;

public class Obj
{
    /// <summary>
    /// Determines whether the specified object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>
    ///   <c>true</c> if the specified object is of type int; otherwise, <c>false</c>.
    /// </returns>
    public bool IsInt(object obj)
    {
        return obj is int;
    }
}
