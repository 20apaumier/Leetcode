using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SlidingWindow
{
    public class MinSizeSub
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int output = 0;

            int curWindow = nums[0];
            while (right <= nums.Length)
            {
                if (curWindow >= target)
                {
                    if (output == 0) { output = right - left + 1; }
                    else { output = Math.Min(output, right - left + 1); }
                    curWindow -= nums[left];
                    left++;
                }
                else
                {
                    right++;
                    if (right == nums.Length) { break; }
                    curWindow += nums[right];
                }
            }

            return output;
        }
    }
}
