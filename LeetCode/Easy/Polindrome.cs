using System.IO.Pipes;

namespace LeetCode.Easy
{
    internal class Polindrome
    {
        public static bool IsPalindorme(int num)
        {
            if (num < 0 && (num % 10 == 0 && num != 0))
            {
                return false;
            }

            var reversedNumber = 0;

            var originalNumber = num;

            while (num > 0)
            {
                var digit = num % 10;
                reversedNumber = reversedNumber * 10 + digit;
                num /= 10;
            }
            return reversedNumber == originalNumber;
        }
    }
}
