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
