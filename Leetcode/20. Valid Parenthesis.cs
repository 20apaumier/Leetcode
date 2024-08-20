using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            // init dictionary with the parenthesis and corresponding values
            Dictionary<char, int> dict = new Dictionary<char, int> {
            {'(', 1},
            {')', 2},
            {'{', 3},
            {'}', 4},
            {'[', 5},
            {']', 6}
        };
            // init stack
            Stack<char> stack = new Stack<char>();

            // go through each char in c
            foreach (char c in s)
            {
                // if it is an opening parenthesis, add it to the stack
                if (dict[c] % 2 == 1) { stack.Push(c); }
                else
                {
                    // it is a closing parenthesis
                    // which means there should be a corresponding opening in the stack
                    // if there are no items in the stack, return false
                    if (stack.Count == 0) { return false; }
                    // if the item on top of the stack is not the same type of parenthesis
                    // return false as it makes it invalid
                    if (dict[stack.Pop()] != dict[c] - 1) { return false; }
                }
            }

            // if there is nothing left in the stack, return true
            return stack.Count == 0;
        }
    }
}
