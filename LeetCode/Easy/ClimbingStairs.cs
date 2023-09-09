using System.Net.WebSockets;

namespace LeetCode.Easy
{
    public class ClimbingStairs
    {
        public static int Execute(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int first = 1;
            int second = 2;
            int output = second;

            for (int i = 3; i <= n; i++)
            {
                output = first + second;
                first = second;
                second = output;
            }

            return output;
        }
    }
}
