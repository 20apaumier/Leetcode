using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    public class Palindrom
    {
        public static bool IsPalindrome(string s)
        {
            // edge case if length is 1, will always be true
            if (s.Length == 1)
            {
                return true;
            }

            // init 2 pointers
            int front = 0;
            int back = s.Length - 1;

            // loop while we do not intersect
            while (back - front > 0)
            {
                // validate both pointers to make sure they are either a letter or digit
                if (char.IsLetterOrDigit(s[front]) == false)
                {
                    // if front is not a letter/digit, skip and continue
                    front++;
                    continue;
                }
                else if (char.IsLetterOrDigit(s[back]) == false)
                {
                    // if back is not a letter/digit, skip and continue
                    back--;
                    continue;
                }

                // good to compare the two pointers
                if (char.ToLower(s[front]) != char.ToLower(s[back]))
                {
                    // if not equal, return false
                    return false;
                }

                // iterate two pointers
                front++;
                back--;
            }

            // if we make it all the way through it is true
            return true;
        }
    }
}
