namespace LeetCode.Easy
{
    public class RemoveElementFromArray
    {
        public static int Execute(int[] nums, int val)
        {
            int result = 0;

            foreach (int number in nums)
            {
                if (number != val)
                {
                    nums[result] = number;
                    result++;
                }
            }
            return result;
        }
    }
}
