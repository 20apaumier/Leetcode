using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class ProductArray
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] output = new int[nums.Length];
            Array.Fill(output, 1);

            // int prefix = 1;
            // for (int i = 0; i < nums.Length; i++) {
            //     output[i] = prefix;
            //     prefix *= nums[i];
            // }

            // int suffix = 1;
            // for (int i = nums.Length - 1; i > -1; i--) {
            //     output[i] *= suffix;
            //     suffix *= nums[i];
            // }


            int prefix = 1;
            int suffix = 1;
            int right = nums.Length - 1;
            for (int left = 0; left < nums.Length; left++)
            {
                output[left] *= prefix;
                prefix *= nums[left];

                output[right] *= suffix;
                suffix *= nums[right];
                right--;
            }

            return output;
        }
    }
}
