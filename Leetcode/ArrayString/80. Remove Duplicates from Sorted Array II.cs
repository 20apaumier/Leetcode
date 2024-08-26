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
            if (nums.Length < 3) { return nums.Length; }
            int insertIntoArray = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[insertIntoArray - 2])
                {
                    nums[insertIntoArray] = nums[i];
                    insertIntoArray++;
                }
            }

            return insertIntoArray;
        }
    }
}
