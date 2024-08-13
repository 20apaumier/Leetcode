namespace Leetcode
{
    public class MergeSortedArrays
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // init pointers for end of nums1 elements, end of nums2, end of nums1
            int i = m - 1; // nums1 elements
            int j = n - 1; // nums2 elements
            int k = m + n - 1; // nums1

            // loop through nums2 and compare end items to nums1
            while (j >= 0)
            {
                // if element in nums1 is greater and i >= 0, add the nums1 element to the end of nums1
                // then increment k and i
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    k--;
                    i--;
                }
                // if element in nums2 is greater (else), then add the nums2 element to the end of nums1
                // then increment k and j    
                else
                {
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
            }
        }
    }
}
