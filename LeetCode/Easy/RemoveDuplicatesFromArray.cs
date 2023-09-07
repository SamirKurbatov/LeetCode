using System.Linq;

namespace LeetCode.Easy;

public class RemoveDuplicatesFromArray
{
    public static int[] Execute(int[] nums)
    {
        int k = 1;
        int previous = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != previous)
            {
                nums[k] = nums[i];
                k++;
            }
            previous = nums[i];
        }

        return nums;
    }
}
