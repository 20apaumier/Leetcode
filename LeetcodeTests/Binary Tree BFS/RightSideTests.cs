using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.Binary_Tree_BFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeTests.Binary_Tree_BFS;
using System.ComponentModel;

namespace Leetcode.Binary_Tree_BFS.Tests
{
    [TestClass()]
    public class RightSideTests
    {
        [TestMethod()]
        public void RightSideViewTest()
        {
            // Arrange
            var root = BinaryTreeBFSHelper.BuildTree([1, 2, 3, null, 5, null, 4]);

            // Act
            IList<int> result = RightSide.RightSideView(root);
            List<int> expected = new List<int> { 1, 3, 4 };

            // Assert
            CollectionAssert.AreEqual(expected, result.ToList());
        }
    }
}