using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.HashMap;

namespace LeetcodeTests.HashMapTests
{
    [TestClass()]
    public class SumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            // Arrange
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            // Act
            int[] result = Sum.TwoSum(nums, target);
            int[] expected = [0, 1];

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TwoSumTest2()
        {
            // Arrange
            int[] nums = [3, 2, 4];
            int target = 6;

            // Act
            int[] result = Sum.TwoSum(nums, target);
            int[] expected = [1, 2];

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TwoSumTest3()
        {
            // Arrange
            int[] nums = [3, 3];
            int target = 6;

            // Act
            int[] result = Sum.TwoSum(nums, target);
            int[] expected = [0, 1];

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}