//To check if the array is sorted and rotated


public class CheckIfTheArrayIsSortedAndRotated
{
    public bool Check(int[] nums)
    {
        int count = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] > nums[(i + 1) % n])
            {
                count++;

            }

        }
        return count <= 1;

    }
}