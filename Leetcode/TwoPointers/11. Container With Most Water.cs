using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    public class MostWater
    {
        public int MaxArea(int[] height) {
            // two pointers
            // move the smaller of the two values at each iteration

            int left = 0;
            int right = height.Length - 1;
            int maxWater = 0;

            while (left < right) {
                maxWater = Math.Max(maxWater, Math.Min(height[left], height[right]) * (right - left));
            
                if (height[left] <= height[right]) {
                    left++;
                } else { 
                    right--;
                }
            }

            return maxWater;
        }
    }
}
