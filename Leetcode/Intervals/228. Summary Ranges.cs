using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Intervals
{
    public class Ranges
    {
        // don't know how to do tests with IList, this works on leetcode.
        public static IList<string> SummaryRanges(int[] nums)
        {
            // init list and handle edge case of nums having no elements
            List<string> output = new List<string>();
            if (nums.Length == 0) return output;

            // init two pointers
            int beginRange = 0;
            int endRange = 0;

            // loop as long as endRange is not touching the end
            while (endRange < nums.Length)
            {
                // make sure we don't go out of bounds and then check if the next element is consecutive
                if (endRange + 1 < nums.Length && nums[endRange + 1] == nums[endRange] + 1)
                {
                    // if next element is +1, increment endRange to extend our range
                    endRange++;
                }
                else
                { // if next element is greater than + 1, the range ends here
                  // if the "range" is a single element just add that
                    if (beginRange == endRange)
                    {
                        output.Add($"{nums[beginRange]}");
                    }
                    else
                    { // add the range to the output
                        output.Add($"{nums[beginRange]}->{nums[endRange]}");
                    }
                    // increment endRange and reset beginRange to start a new range
                    endRange++;
                    beginRange = endRange;
                }
            }

            return output;
        }
    }
}
