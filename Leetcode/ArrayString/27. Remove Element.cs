using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class RemoveElement
    {
        public static int Remove(int[] nums, int val)
        {
            // given an integer array, nums, and an integer, val.
            // remove ALL occurances of val in nums in-place
            // the order of the elements may be changed.
            // return the number of elements in nums which are not equal to val

            // want to use overwriting
            // init pointer to enter "k" (any item that does not equal val)
            // into the beginning of the array so that we "remove" any values
            // that are equal to val by sending them to the end of the array

            // loop through nums and check if the nums value is not equal to val
            // if true, insert the nums value at the enterIntoArray pointer and increment
            // return the pointer as it also acts as a counter
            int enterIntoArray = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[enterIntoArray] = nums[i];
                    enterIntoArray++;
                }
            }

            return enterIntoArray;

            // O(n) time, O(1) space
        }
    }
}
