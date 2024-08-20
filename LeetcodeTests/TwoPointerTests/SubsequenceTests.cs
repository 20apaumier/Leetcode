using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.TwoPointers;

namespace LeetcodeTests.TwoPointerTests
{
    [TestClass()]
    public class SubsequenceTests
    {
        [TestMethod()]
        public void IsSubsequenceTest()
        {
            // Arrange
            string s = "abc";
            string t = "ahbgdc";

            // Act
            bool result = Subsequence.IsSubsequence(s, t);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsSubsequenceTest2()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgc";

            // Act
            bool result = Subsequence.IsSubsequence(s, t);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}