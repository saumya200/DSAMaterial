//Second Largest Element In an array without sorting

// User function template for C++
class Solution
{
    public int SecondLargestElementInAnArray(List<int> arr)
    {
        // Code Here
        int max = arr[0];
        int secondMax = -1;

        for (int i = 1; i < arr.Count(); i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        for (int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] > secondMax && arr[i] != max)
            {
                secondMax = arr[i];
            }
        }
        return secondMax;
    }
};


// ================================================
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 5, 7, 9, 8 };
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        if (arr == null || arr.Length < 2)
        {
            Console.WriteLine("ArgumentException");
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];

            }
            else if (arr[i] > secondLargest && arr[i] < largest)
            {
                secondLargest = arr[i];
            }
        }
        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("InvalidExceptionOperation");
        }
        Console.WriteLine(secondLargest);


    }
}