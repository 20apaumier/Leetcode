using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            // keep track of max jump from start
            int maxJump = nums[0]; // init maxJump

            for (int i = 0; i < nums.Length; i++)
            {
                // if we have over extended our jump, return false
                // ex: i = 6, maxReach = 5
                // we are not allowed to be at i = 6
                if (i > maxJump) { return false; }

                maxJump = Math.Max(maxJump, i + nums[i]); // update maxJump

                // if we are able to reach the end
                if (maxJump >= nums.Length - 1) { return true; }
            }

            return false;
        }
    }
}
