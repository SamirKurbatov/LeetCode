using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class ValidPairbrackets
    {
        public static bool Execute(string s)
        {
            Dictionary<char, char> dict = new()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' }
            };

            var stack = new Stack<char>();

            foreach (var bracket in s)
            {
                if (dict.ContainsKey(bracket))
                    stack.Push(bracket);
                else if (dict.ContainsValue(bracket))
                {
                    var openBracket = stack.Pop();
                    if (stack.Count == 0 || dict[openBracket] != bracket)
                    {
                        return false;
                    }
                }

            }

            return stack.Count == 0;
        }
    }
}
