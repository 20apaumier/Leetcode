using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Dupes
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0) { return false; }

            HashSet<int> window = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (window.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    // rmeove first element in window
                    if (window.Count == k) { window.Remove(nums[i - k]); }
                    // add cur element
                    window.Add(nums[i]);
                }
            }

            // no dupes
            return false;
        }
    }
}
