
using System;
using System.Collections.Generic;
class ArraysEasy
{
    public int LargestElementInAnArray(List<int> arr)
    {
        // code here.
        int max = arr[0];

        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];

            }
        }
        return max;

    }
}

// =============================================================================================================================
// Another solution

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 5, 9, 2, 6 };

        int longest = int.MinValue;

        if (arr == null || arr.Length < 1)
        {
            Console.WriteLine("ArgumentException: Array should atleast have two values.");
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > longest)
            {
                longest = arr[i];
            }
            else if (longest == int.MinValue)
            {
                Console.WriteLine("InvalidExceptionOperation: Longest Value not found");
            }
        }

        Console.WriteLine(longest);
    }
}