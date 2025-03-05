
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
