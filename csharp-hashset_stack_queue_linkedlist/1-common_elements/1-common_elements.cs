using System;
using System.Collections.Generic;

public class List
{
    // Method to find common elements and return them sorted
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> commonSet = new HashSet<int>();

        // Find common elements
        foreach (int element in list2)
        {
            if (set1.Contains(element))
            {
                commonSet.Add(element);
            }
        }

        // Convert the HashSet to a List
        List<int> commonList = new List<int>(commonSet);

        // Sort the list using a simple sorting algorithm (e.g., Bubble Sort)
        for (int i = 0; i < commonList.Count - 1; i++)
        {
            for (int j = 0; j < commonList.Count - i - 1; j++)
            {
                if (commonList[j] > commonList[j + 1])
                {
                    // Swap
                    int temp = commonList[j];
                    commonList[j] = commonList[j + 1];
                    commonList[j + 1] = temp;
                }
            }
        }

        return commonList;  // Ensure we return the sorted list
    }
}
