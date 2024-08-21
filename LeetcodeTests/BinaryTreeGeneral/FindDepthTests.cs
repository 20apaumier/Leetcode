using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeTests.BinaryTreeGeneral;

namespace Leetcode.BinaryTreeGeneral.Tests
{
    [TestClass()]
    public class FindDepthTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            var node = BinaryTreeHelper.BuildTree([3, 9, 20, null, null, 15, 7]);
            int expected = 3;
            int actual = FindDepth.MaxDepth(node);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDepthTest2()
        {
            var node = BinaryTreeHelper.BuildTree([1, null, 2]);
            int expected = 2;
            int actual = FindDepth.MaxDepth(node);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void MaxDepthIterativeTest()
        {
            var node = BinaryTreeHelper.BuildTree([3, 9, 20, null, null, 15, 7]);
            int expected = 3;
            int actual = FindDepth.MaxDepthIterative(node);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDepthIterativeTest2()
        {
            var node = BinaryTreeHelper.BuildTree([1, null, 2]);
            int expected = 2;
            int actual = FindDepth.MaxDepthIterative(node);
            Assert.AreEqual(expected, actual);
        }
    }
}