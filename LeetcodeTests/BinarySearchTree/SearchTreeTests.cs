using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.BinaryTreeGeneral;
using Leetcode.BinarySearchTree.Tests;

namespace Leetcode.BinarySearchTree.Tests
{
    [TestClass()]
    public class SearchTreeTests
    {
        [TestMethod()]
        public void GetMinimumDifferenceTest()
        {
            // Arrange
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(1);
            root.right.right = new TreeNode(3);

            SearchTree searchTree = new SearchTree();

            // Act
            int result = searchTree.GetMinimumDifference(root);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetMinimumDifference_ComplexTree()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(48);
            root.right.left = new TreeNode(12);
            root.right.right = new TreeNode(49);

            SearchTree searchTree = new SearchTree();

            // Act
            int result = searchTree.GetMinimumDifference(root);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetMinimumDifference_SingleNode()
        {
            // Arrange
            TreeNode root = new TreeNode(1);

            SearchTree searchTree = new SearchTree();

            // Act
            int result = searchTree.GetMinimumDifference(root);

            // Assert
            Assert.AreEqual(int.MaxValue, result); // No other node to compare, so max value
        }
    }
}