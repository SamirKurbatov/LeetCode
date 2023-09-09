namespace LeetCode.Easy
{
    public class LengthOfLastWord
    {
        public static int Execute(string s)
        {
            return s.Trim().Split().Last().Length;
        }
    }
}
