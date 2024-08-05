using System;
using System.Collections.Generic;

public class List
{
    // Method to sum unique integers in the list
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>(myList);
        int sum = 0;

        foreach (int number in uniqueNumbers)
        {
            sum += number;
        }
        return sum;
    }
}
