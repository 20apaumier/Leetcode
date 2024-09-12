using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Intervals
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            // sort the input by the first item in the inner array
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> output = new List<int[]>();
            int[] prev = intervals[0];
            
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] interval = intervals[i];
                if (interval[0] <= prev[1])
                {
                    // merge
                    prev[1] = Math.Max(prev[1], interval[1]);
                } else
                {
                    output.Add(prev);
                    prev = interval;
                }
            }

            output.Add(prev);
            return output.ToArray();
        }
    }
}
