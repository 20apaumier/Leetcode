using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BuyAndSell
    {
        public static int MaxProfit(int[] prices)
        {
            // init current minimum to the first element in prices
            // and curProfit to 0, in case we can't find profit
            int curMin = prices[0];
            int curProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                // if today's price is less than the curMin, update curMin
                if (prices[i] < curMin) { curMin = prices[i]; }
                // else, the current price is higher than the min, so profit is made
                // update the current profit to the max of either the one calculated
                // right now, or the previous curProfit
                else { curProfit = Math.Max(curProfit, prices[i] - curMin); }
            }

            return curProfit;
        }
    }
}
