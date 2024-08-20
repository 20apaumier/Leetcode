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
    public class DupesTests
    {
        [TestMethod()]
        public void ContainsNearbyDuplicateTest()
        {
            // Arrange
            int[] nums = [1, 2, 3, 1];
            int k = 3;

            // Act
            bool result = Dupes.ContainsNearbyDuplicate(nums, k);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicateTest2()
        {
            // Arrange
            int[] nums = [1, 0, 1, 1];
            int k = 1;

            // Act
            bool result = Dupes.ContainsNearbyDuplicate(nums, k);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicateTest3()
        {
            // Arrange
            int[] nums = [1, 2, 3, 1, 2, 3];
            int k = 2;

            // Act
            bool result = Dupes.ContainsNearbyDuplicate(nums, k);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}