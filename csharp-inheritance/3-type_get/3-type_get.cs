using System;
using System.Reflection;

public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object whose properties and methods are to be printed.</param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"{objType.Name} Properties:");

        PropertyInfo[] properties = objType.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{objType.Name} Methods:");

        MethodInfo[] methods = objType.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}