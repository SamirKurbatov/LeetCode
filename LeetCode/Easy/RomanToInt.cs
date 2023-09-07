namespace LeetCode.Easy
{
    internal class RomanToInt
    {
        public static int Execute(string text)
        {
            var symbolPairs = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int sum = 0;

            int prevValue = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                int currentValue = symbolPairs[text[i]];

                if (currentValue >= prevValue)
                {
                    sum += currentValue;
                }
                else
                {
                    sum -= currentValue;
                }

                prevValue = currentValue;
            }

            return sum;
        }
    }
}
