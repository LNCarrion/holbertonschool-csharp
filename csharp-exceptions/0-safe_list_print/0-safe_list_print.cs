﻿using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for (int i=0; 1 < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            return count;
        }
        return count;
    }
}