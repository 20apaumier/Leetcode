using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.Binary_Tree_BFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeTests.Binary_Tree_BFS;

namespace Leetcode.Binary_Tree_BFS.Tests
{
    [TestClass]
    public class BinaryTreeAverageLevelsTests
    {
        [TestMethod()]
        public void AverageOfLevelsTest()
        {
            // Arrange
            var root = BinaryTreeBFSHelper.BuildTree([3, 9, 20, null, null, 15, 7]);

            // Act
            IList<double> result = BinaryTreeAverageLevels.AverageOfLevels(root);
            List<double> expected = new List<double> { 3.00000, 14.50000, 11.00000 };

            // Assert
            CollectionAssert.AreEqual(expected, result.ToList());
        }
    }
}