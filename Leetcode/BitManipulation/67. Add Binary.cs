using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BitManipulation
{
    public class AddBin
    {
        public static string AddBinary(string a, string b)
        {
            // this solution mimics adding binary by hand
            // start from the rightmost digits
            // add the digits along with any carry
            // the results least significant big becomes part of the answer
            // any overflow becomes the carry for the next addition
            // continue until we've processed all digits and there's no more carry

            StringBuilder sb = new StringBuilder();
            int aPointer = a.Length - 1; // pointer to end of a
            int bPointer = b.Length - 1; // pointer to end of b
            int carry = 0; // keeps track of any carry-over from adding bits

            // while there are digits left in either string or there is still a carry
            while (aPointer >= 0 || bPointer >= 0 || carry > 0)
            {
                // start the sum with the current value of carry
                int sum = carry;

                // if digits left in a, convert the next one to a bit by doing - '0'
                // add it to the sum, and decrement the a pointer
                if (aPointer >= 0)
                {
                    sum += a[aPointer] - '0';
                    aPointer--;
                }

                // if digits left in b, convert the next one to a bit by doing - '0'
                // add it to the sum, and decrement the b pointer
                if (bPointer >= 0)
                {
                    sum += b[bPointer] - '0';
                    bPointer--;
                }

                // sum % 2 gives us the least significant bit, 0 or 1
                // add '0' to convert it back to a char and insert it into
                // the beginning of the sb
                sb.Insert(0, (char)(sum % 2 + '0'));

                // this will calculate the new carry (0 or 1)
                carry = sum / 2;
            }

            return sb.ToString();

            // Time: O(max(m,n)) Space (O(max(m,n))
        }
    }
}
