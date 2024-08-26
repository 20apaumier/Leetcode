using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class RemoveDupesII
    {
        public int RemoveDuplicates(int[] nums)
        {
            // no dupes
            if (nums.Length < 3) { return nums.Length; }

            // "slow pointer"
            int insertIntoArray = 2;

            // loop starting at 2 for efficiency!
            for (int i = 2; i < nums.Length; i++)
            {
                // if not a dupe, overwrite at insert position
                // then increment insertion position
                // ("fast pointer" i automatically increments every time)
                if (nums[i] != nums[insertIntoArray - 2])
                {
                    nums[insertIntoArray] = nums[i];
                    insertIntoArray++;
                }

                // if it is a dupe, we want to just keep going with i (fast pointer)
                // so that we can find the next position that isn't a dupe
            }

            return insertIntoArray;
        }
    }
}
