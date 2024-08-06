﻿using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();

            while (aStack.Count > 0)
            {
            string item = aStack.Pop();

            if (item == search)
            {
                aStack.Push(newItem);
                break;
            }

            }

        }

        return aStack;
    }
}