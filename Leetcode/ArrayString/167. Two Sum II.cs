using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class TwoSum2
    {
        public int[] TwoSumII(int[] numbers, int target)
        {
            // init left to start of numbers and right to end of numbers
            int left = 0;
            int right = numbers.Length - 1;

            // while left and right don't intersect
            while (left <= right)
            {
                // if target is smaller, decrement right pointer
                if (target < (numbers[left] + numbers[right]))
                {
                    right--;
                }
                // if target is bigger, increment left pointer
                else if (target > (numbers[left] + numbers[right]))
                {
                    left++;
                }
                // else we hit the target, so return left+1, right+1 for 1-based indexing
                else
                {
                    return [left + 1, right + 1];
                }
            }

            // didn't find target in numbers
            return [-1, -1];
        }
    }
}
