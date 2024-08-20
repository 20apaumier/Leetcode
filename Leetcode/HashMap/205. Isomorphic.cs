using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.HashMap
{
    public class Isomorphic
    {
        public static bool IsIsomorphic(string s, string t)
        {
            // char -> char key value pair
            Dictionary<char, char> sto = new Dictionary<char, char>();

            int i = 0;
            while (i < s.Length)
            {
                if (sto.ContainsKey(s[i])) // if cur char in s is already in the dict
                {
                    // if the map doesn't match, return false
                    if (sto[s[i]] != t[i]) { return false; }
                }
                else // if cur char in s is not already in the dict
                {
                    // check to make sure it is not already mapped as a vaue
                    if (sto.ContainsValue(t[i])) { return false; }

                    // add new map if not already in
                    sto[s[i]] = t[i];
                }
                i++;
            }

            // if we make it all the way through, return true as it is isomorphic
            return true;
        }

        // O(n) time, O(n) space
    }
}
