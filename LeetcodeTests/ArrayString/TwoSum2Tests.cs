using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString.Tests
{
    [TestClass()]
    public class TwoSum2Tests
    {
        [TestMethod()]
        public void TwoSum2Test()
        {
            // Arramge
            int[] numbers = [2, 7, 11, 15];
            int target = 9;
            TwoSum2 ts = new TwoSum2();

            // Act
            int[] expected = [ 1, 2 ];
            int[] result = ts.TwoSumII(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TwoSum2Test2()
        {
            // Arramge
            int[] numbers = [2, 3, 4 ];
            int target = 6;
            TwoSum2 ts = new TwoSum2();

            // Act
            int[] expected = [1, 3];
            int[] result = ts.TwoSumII(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TwoSum2Test3()
        {
            // Arramge
            int[] numbers = [-1, 0];
            int target = -1;
            TwoSum2 ts = new TwoSum2();

            // Act
            int[] expected = [1, 2 ];
            int[] result = ts.TwoSumII(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}