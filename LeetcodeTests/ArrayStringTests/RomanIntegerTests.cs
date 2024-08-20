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
    public class RomanIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            // Arrange
            string s = "III";

            // Act
            int result = RomanInteger.RomanToInt(s);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RomanToIntTest2()
        {
            // Arrange
            string s = "LVIII";

            // Act
            int result = RomanInteger.RomanToInt(s);
            int expected = 58;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RomanToIntTest3()
        {
            // Arrange
            string s = "MCMXCIV";

            // Act
            int result = RomanInteger.RomanToInt(s);
            int expected = 1994;

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void RomanToIntRefactoredTest()
        {
            // Arrange
            string s = "III";

            // Act
            int result = RomanInteger.RomanToIntRefactored(s);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RomanToIntRefactoredTest2()
        {
            // Arrange
            string s = "LVIII";

            // Act
            int result = RomanInteger.RomanToIntRefactored(s);
            int expected = 58;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RomanToIntRefactoredTest3()
        {
            // Arrange
            string s = "MCMXCIV";

            // Act
            int result = RomanInteger.RomanToIntRefactored(s);
            int expected = 1994;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}