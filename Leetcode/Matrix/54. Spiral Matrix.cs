using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.Matrix
{
    public class Spiral
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            // output List
            List<int> output = new List<int>();
            int top = 0;
            int left = 0;
            int right = matrix[0].Length - 1;
            int bottom = matrix.Length - 1;

            // expected amount of elements
            int expected = matrix.Length * matrix[0].Length;

            while (output.Count < expected)
            {
                // go to the right
                for (int i = left; i <= right && output.Count < expected; i++)
                {
                    output.Add(matrix[top][i]);
                }
                top++;

                // go down
                for (int i = top; i <= bottom && output.Count < expected; i++)
                {
                    output.Add(matrix[i][right]);
                }
                right--;

                // go to the left
                for (int i = right; i >= left && output.Count < expected; i--)
                {
                    output.Add(matrix[bottom][i]);
                }
                bottom--;

                // go up
                for (int i = bottom; i >= top && output.Count < expected; i--)
                {
                    output.Add(matrix[i][left]);
                }
                left++;
            }

            
            // return output
            return output;
        }
    }
}
