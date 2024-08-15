using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass()]
    public class PatternWordTests
    {
        [TestMethod()]
        public void WordPatternTest()
        {
            // Arrange
            string pattern = "abba";
            string s = "dog cat cat dog";

            // Act
            bool result = PatternWord.WordPattern(pattern, s);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void WordPatternTest2()
        {
            // Arrange
            string pattern = "abba";
            string s = "dog cat cat fish";

            // Act
            bool result = PatternWord.WordPattern(pattern, s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void WordPatternTest3()
        {
            // Arrange
            string pattern = "aaaa";
            string s = "dog cat car dog";

            // Act
            bool result = PatternWord.WordPattern(pattern, s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}