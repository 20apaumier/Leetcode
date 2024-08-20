using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.ArrayString;

namespace LeetcodeTests.ArrayStringTests
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            // Arrange
            int[] nums = [1, 1, 2];

            // Act
            int actual = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);
            int expectedNumOfUniqueElements = 2;

            int[] expectedArray = [1, 2, 2];

            // Assert
            Assert.AreEqual(expectedNumOfUniqueElements, actual);
            CollectionAssert.AreEqual(expectedArray, nums);
        }

        [TestMethod()]
        public void RemoveDuplicatesTest2()
        {
            // Arrange
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            // Act
            int actual = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);
            int expectedNumOfUniqueElements = 5;

            int[] expectedArray = [0, 1, 2, 3, 4, 2, 2, 3, 3, 4];

            // Assert
            Assert.AreEqual(expectedNumOfUniqueElements, actual);
            CollectionAssert.AreEqual(expectedArray, nums);
        }
    }
}