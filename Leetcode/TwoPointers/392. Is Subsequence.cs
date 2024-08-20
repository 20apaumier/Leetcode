using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    public class Subsequence
    {
        public static bool IsSubsequence(string s, string t)
        {
            // edge case if no subsequence, it will always be true
            if (s.Length == 0) return true;

            int i = 0;
            int j = 0;

            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    // if we are at the end, return true
                    if (i == s.Length - 1) { return true; }

                    // it does appear, so increment i in s and j in t
                    i++;
                    j++;
                }
                else
                {
                    // if it does not appear at current index, increment j in t
                    // if we are at the end, return false
                    if (j == t.Length - 1) { return false; }
                    j++;
                }
            }

            // if we make it out here it will be false
            return false;
        }
    }
}
