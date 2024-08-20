using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.HashMap
{
    public class PatternWord
    {
        public static bool WordPattern(string pattern, string s)
        {
            // init dict and split up s so we can use it easily
            Dictionary<char, string> sto = new Dictionary<char, string>();
            string[] compareS = s.Split();

            // edge case to check length of split and pattern to make sure they are the same
            if (compareS.Length != pattern.Length) { return false; }

            int i = 0;
            while (i < pattern.Length)
            {
                if (sto.ContainsKey(pattern[i])) // if key in dict
                {
                    // validate the current map
                    if (sto[pattern[i]] != compareS[i]) { return false; } // it is not a match
                }
                else // if the key is not in dict already
                {
                    if (sto.ContainsValue(compareS[i])) { return false; } // if the value is already mapped, return false
                    sto[pattern[i]] = compareS[i];
                }
                // increment i to keep while loop going
                i++;
            }

            // made it all the way through pattern so its a match
            return true;
        }
    }
}
