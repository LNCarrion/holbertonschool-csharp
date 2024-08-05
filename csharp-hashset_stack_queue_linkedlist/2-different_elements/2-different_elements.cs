using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> uniqueElements = new List<int>();

        foreach (int element in list1)
        {
            if (!set2.Contains(element))
            {
                uniqueElements.Add(element);
            }
        }

        foreach (int element in list2)
        {
            if (!set1.Contains(element))
            {
                uniqueElements.Add(element);
            }
        }
        uniqueElements.Sort();

        return uniqueElements;
    }
}