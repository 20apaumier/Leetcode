using Leetcode.Stacks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.StackTests
{
    [TestClass()]
    public class ValidParenthesisTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            // Arrange
            string s = "()";

            // Act
            bool result = ValidParenthesis.IsValid(s);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            // Arrange
            string s = "()[]{}";

            // Act
            bool result = ValidParenthesis.IsValid(s);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            // Arrange
            string s = "(]";

            // Act
            bool result = ValidParenthesis.IsValid(s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}