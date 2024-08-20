using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.HashMap
{
    public class Anagra
    {
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            // make counter for s
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            // loop through t and decrement/delete items in counts
            foreach (char c in t)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]--;
                    if (counts[c] == 0) { counts.Remove(c); }
                }
                else
                {
                    // if the char is not in the counts that mean it is unknown
                    return false;
                }
            }

            return counts.Count == 0;
        }

        // O(m + n) time, O(m) space
    }
}
