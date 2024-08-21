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
    public class CountCompletesTests
    {
        [TestMethod()]
        public void CountNodesTest()
        {
            var root = BinaryTreeHelper.BuildTree([1, 2, 3, 4, 5, 6]);
            int expected = 6;
            int actual = new CountCompletes().CountNodes(root);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountNodesTest2()
        {
            var root = BinaryTreeHelper.BuildTree([1, 2, 3, 4]);
            int expected = 4;
            int actual = new CountCompletes().CountNodes(root);
            Assert.AreEqual(expected, actual);
        }
    }
}