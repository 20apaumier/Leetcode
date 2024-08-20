using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class LengthLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            //return s.Trim().Split().Last().Length;
            return s.TrimWhiteSpace().SplitStringBySpace().Last().Length;

            // next time do last index of lol
        }
    }

    public static class ExtensionMethods
    {
        public static string TrimWhiteSpace(this string s)
        {
            // remove leading white space
            int countSpace = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    countSpace++;
                }
                else
                {
                    break;
                }
            }

            s = s[countSpace..];


            // remove trailing white space
            countSpace = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    countSpace++;
                }
                else
                {
                    break;
                }
            }

            //s.Remove(s.Length - countSpace);
            return s = s[..(s.Length - countSpace)];
        }

        public static string[] SplitStringBySpace(this string s)
        {
            // the given string will already have leading and trailing
            // spaces removed, no need to handle those edge cases
            if (string.IsNullOrEmpty(s))
            {
                return Array.Empty<string>();
            }


            // list so array is dynamic
            List<string> output = new List<string>();

            int curPoint = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    output.Add(s.Substring(curPoint, i - curPoint));
                    curPoint = i + 1;
                }
            }

            // Add the last segment
            if (curPoint < s.Length)
            {
                output.Add(s.Substring(curPoint));
            }

            // convert to string array
            return output.ToArray();
        }

        // still need to do last extension method

    }
}
