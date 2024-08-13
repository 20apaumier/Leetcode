using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // given an integer array nums, which is sorted
            // remove the duplicates in-place such that each unique element only occurs once
            // the relative order of the elements should be kept the same
            // return the number of unique elements


            // want to use overwriting
            // start at index 1, 1st element will always be unique
            // also we don't run into index out of range errors this way

            int insertIntoArray = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[insertIntoArray] = nums[i];
                    insertIntoArray++;
                }
            }

            return insertIntoArray;

            // O(n), O(1)
        }

    }
}
