using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class ReverseWordsString
    {
        public string ReverseWords(string s)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && word.Length != 0)
                {
                    stack.Push(word.ToString());
                    word = new StringBuilder();
                }

                if (s[i] != ' ') { word.Append(s[i]); }
            }
            if (word.Length != 0) { stack.Push(word.ToString()); } // leftovers

            StringBuilder output = new StringBuilder();
            while (stack.Count > 1)
            {
                output.Append($"{stack.Pop()} ");
            }
            output.Append(stack.Pop());

            return output.ToString();
        }
    }
}
