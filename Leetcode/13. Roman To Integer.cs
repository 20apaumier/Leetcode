using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RomanInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int> { 
                { "I", 1 }, {"V", 5}, {"X",10}, {"L", 50 }, {"C", 100}, {"D", 500}, {"M", 1000}, // "singles"
                {"IV", 4}, {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400}, {"CM", 900} // "doubles"
            };

            int output = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // peak at 2 and see if its in the dict
                if (i != s.Length - 1 && dict.ContainsKey($"{s[i]}{s[i+1]}"))
                {
                    output += dict[$"{s[i]}{s[i + 1]}"];
                    i += 1; // increment an extra i
                } else // add single value to output
                {
                    output += dict[$"{s[i]}"];
                }
            }

            return output;
        }

        public static int RomanToIntRefactored(string s)
        {
            // change dict to chars
            // do math to see if next element is greater than current one
            // if so, add the doubles element to the output

            Dictionary<char, int> dict = new Dictionary<char, int> {
                { 'I', 1 }, {'V', 5}, {'X',10}, {'L', 50 }, {'C', 100}, {'D', 500}, { 'M', 1000}, // "singles"
            };

            int output = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // peak at 2 and see if its in the dict
                if (i != s.Length - 1 && dict[s[i]] < dict[s[i+1]] )
                {
                    // get currect double amount
                    output += dict[s[i+1]] - dict[s[i]];
                    i += 1; // increment an extra i
                }
                else // add single value to output
                {
                    output += dict[s[i]];
                }
            }

            return output;
        }
    }
}
