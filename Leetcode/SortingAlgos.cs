using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SortingAlgos
    {
        public static void MergeSort(int[] nums)
        {
            // Time: O(nlogn) Space: O(n)


            if (nums.Length <= 1) { return; } // if <= 1 it is already sorted

            // divide the array into two halves
            // init mid pointer, left, and right int arrays
            int mid = nums.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[nums.Length - mid];

            // populate left and right subarrays
            for (int i = 0; i < mid; i++)
            {
                left[i] = nums[i];
            }
            for (int i = mid; i < nums.Length; i++)
            {
                right[i - mid] = nums[i];
            }

            // recursively call MergeSort on left and right halves
            MergeSort(left);
            MergeSort(right);
            // combine the sorted halves
            Merge(nums, left, right);

        }

        public static void Merge(int[] nums, int[] left, int[] right)
        {
            // i, j, and k pointer
            int i = 0;
            int j = 0;
            int k = 0;

            // loop through left and right arrays
            // compare elements from both arrays
            // place the smaller one into nums first
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    nums[k] = left[i];
                    i++;
                } else
                {
                    nums[k] = right[j];
                    j++;
                }
                k++;
            }

            // any remaining elements are then copied into the end of the array
            while (i < left.Length)
            {
                nums[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                nums[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
