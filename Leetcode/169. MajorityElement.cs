using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MajorityElement
    {
        public static int Majority(int[] nums)
        {
            // given an int array nums
            // return the element that appears more than n/s times
            // assuming there is always a majority element.

            // solve in linear time and O(1) space
            // NO DICTIONARY!!

            // idea -> increment and decrement count based on appearance
            // good good good

            // refactor to start at i and count being 1 because we will always
            // start with the first element anyways

            int count = 1;
            int num = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                // change count based on if cur item in nums is equal to num
                if (nums[i] == num) { 
                    count++;
                } else { count--; }

                // check count AFTER changing above count
                // incase it is the last element (see 21122 example)
                if (count == 0) {
                    num = nums[i];
                    count = 1;
                }
            }

            return num;

            // O(n) O(1)
        }

        public static int MajorityWithTup(int[] nums)
        {
            // given an int array nums
            // return the element that appears more than n/s times
            // assuming there is always a majority element.

            // solve in linear time and O(1) space
            // NO DICTIONARY!!

            // idea -> increment and decrement count based on appearance
            // good good good

            // refactor to start at i and count being 1 because we will always
            // start with the first element anyways

            (int count, int num) sto = (1, nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                // change count based on if cur item in nums is equal to num
                if (nums[i] == sto.num)
                {
                    sto.count++;
                }
                else { sto.count--; }

                // check count AFTER changing above count
                // incase it is the last element (see 21122 example)
                if (sto.count == 0)
                {
                    sto.num = nums[i];
                    sto.count = 1;
                }
            }

            return sto.num;

            // O(n) O(1)
        }
    }
}
