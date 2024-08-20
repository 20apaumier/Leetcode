using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.HashMap
{
    public class Ransom
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            // init a dictionary to be used as a counter
            Dictionary<char, int> sto = new Dictionary<char, int>();

            // add the items of magazine to the counter
            foreach (char c in magazine)
            {
                if (sto.ContainsKey(c))
                {
                    sto[c]++;
                }
                else
                {
                    sto[c] = 1;
                }
            }

            // loop through ransom note
            foreach (char c in ransomNote)
            {
                // if c is in sto
                if (sto.ContainsKey(c))
                {
                    // if the count is 0, it means we have no chars left so we return false
                    if (sto[c] == 0) { return false; }

                    // we want to decrement the count because it appears in ransom note
                    sto[c]--;
                }
                else { return false; } // if char in ransom note is not in sto, return false
            }

            // if we make it out of the prev loop, we return true because all the items in ransomNote are in magazine
            return true;
        }

        // O(m + n) O(n)
    }
}
