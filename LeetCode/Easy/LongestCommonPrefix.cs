
using System.Text;

namespace LeetCode.Easy
{
    internal class LongestCommonPrefix
    {
        public static string Execute(string[] strs)
        {
            var shortest = strs.OrderBy(s => s.Length).FirstOrDefault();

            var sb = new StringBuilder();
            foreach (var (c, i) in shortest.Select((c, i) => (c, i)))
            {
                if (strs.Any(s => s[i] != c))
                {
                    break;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
