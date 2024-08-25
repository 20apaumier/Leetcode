using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.BinaryTreeGeneral;

namespace Leetcode.BinarySearchTree.Tests
{
    [TestClass()]
    public class KthSmallestElementTests
    {
        [TestMethod()]
        public void KthSmallestTest()
        {
            // Arrange
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);

            KthSmallestElement kth = new KthSmallestElement();

            // Act
            int result = kth.KthSmallest(root, 1);
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}