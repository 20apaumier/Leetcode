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
            StringBuilder sb = new StringBuilder();
            int aPointer = a.Length - 1;
            int bPointer = b.Length - 1;
            int carry = 0;

            while (aPointer >= 0 || bPointer >= 0 || carry > 0)
            {
                int sum = carry;

                if (aPointer >= 0)
                {
                    sum += a[aPointer] - '0';
                    aPointer--;
                }

                if (bPointer >= 0)
                {
                    sum += b[bPointer] - '0';
                    bPointer--;
                }

                sb.Insert(0, (char)(sum % 2 + '0'));
                carry = sum / 2;
            }

            return sb.ToString();
        }
    }
}
