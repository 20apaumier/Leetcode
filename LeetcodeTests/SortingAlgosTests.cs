using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass()]
    public class SortingAlgosTests
    {
        [TestMethod()]
        public void MergeSortTest()
        {
            // Arrange
            int[] nums = { 5, 4, 2, 3, 1 };

            // Act
            SortingAlgos.MergeSort(nums);
            int[] expected = { 1, 2, 3, 4, 5 };

            // Assert
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}