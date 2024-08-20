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
    public class PalindromTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama";

            // Act
            bool result = Palindrom.IsPalindrome(s);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsPalindromeTest2()
        {
            // Arrange
            string s = "race a car";

            // Act
            bool result = Palindrom.IsPalindrome(s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsPalindromeTest3()
        {
            // Arrange
            string s = " ";

            // Act
            bool result = Palindrom.IsPalindrome(s);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsPalindromeTest4()
        {
            // Arrange
            string s = "nopenotone";

            // Act
            bool result = Palindrom.IsPalindrome(s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsPalindromeTest5()
        {
            // Arrange
            string s = "ab";

            // Act
            bool result = Palindrom.IsPalindrome(s);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}