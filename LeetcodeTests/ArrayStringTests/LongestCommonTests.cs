using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.ArrayString;

namespace LeetcodeTests.ArrayStringTests
{
    [TestClass()]
    public class LongestCommonTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            // Arrange
            string[] strs = ["flowers", "flow", "flight"];

            // Act
            string result = LongestCommon.LongestCommonPrefix(strs);
            string expected = "fl";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest2()
        {
            // Arrange
            string[] strs = ["dog", "racecar", "car"];

            // Act
            string result = LongestCommon.LongestCommonPrefix(strs);
            string expected = "";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest3()
        {
            // Arrange
            string[] strs = ["", ""];

            // Act
            string result = LongestCommon.LongestCommonPrefix(strs);
            string expected = "";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest4()
        {
            // Arrange
            string[] strs = ["flower", "flower", "flower", "flower"];

            // Act
            string result = LongestCommon.LongestCommonPrefix(strs);
            string expected = "flower";

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}