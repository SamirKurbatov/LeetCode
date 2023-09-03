using System.Globalization;

namespace LeetCode.Easy
{
    public class TwoSum
    {
        public static int[] Execute(int[] array, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var reason = target - array[j];

                    if (!dict.ContainsKey(reason))
                    {
                        dict.Add(reason, array[j]);
                    }

                    if (dict[reason] + array[i] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
