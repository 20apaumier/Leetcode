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
    public class ValidateBSTTests
    {
        [TestMethod()]
        public void IsValidBSTTest()
        {
            // Arrange
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);

            ValidateBST valid = new ValidateBST();

            // Act
            bool result = valid.IsValidBST(root);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsValidBSTTest2()
        {
            // Arrange
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(6);


            ValidateBST valid = new ValidateBST();

            // Act
            bool result = valid.IsValidBST(root);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}