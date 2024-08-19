using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Happy
    {
        public static bool IsHappy(int n)
        {
            HashSet<int> sto = new HashSet<int>();
            int num = n;
            string stringNum = n.ToString();

            while (num != 1)
            {
                if (sto.Contains(num))
                {
                    return false; // we are starting to loop
                }
                else
                {
                    sto.Add(num);
                }

                int newNum = 0;
                foreach (char c in stringNum)
                {
                    newNum += (int.Parse(c.ToString()) * int.Parse(c.ToString()));
                }

                stringNum = newNum.ToString();
                num = newNum;
            }

            return true;
        }
    }
}
