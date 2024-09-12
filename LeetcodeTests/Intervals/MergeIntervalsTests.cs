using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.Intervals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Intervals.Tests
{
    [TestClass()]
    public class MergeIntervalsTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            // Arrange
            int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
            MergeIntervals mi = new MergeIntervals();

            // Act
            int[][] expected = [[1, 6], [8, 10], [15, 18]];
            int[][] result = mi.Merge(intervals);

            // Assert
            for (int i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], result[i]);
            }
            
        }

        [TestMethod()]
        public void MergeTest2()
        {
            // Arrange
            int[][] intervals = [[1, 4], [4, 5]];
            MergeIntervals mi = new MergeIntervals();

            // Act
            int[][] expected = [[1, 5]];
            int[][] result = mi.Merge(intervals);

            // Assert
            for (int i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], result[i]);
            }
        }
    }
}