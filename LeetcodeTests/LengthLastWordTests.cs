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
    public class LengthLastWordTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            // Arrange
            string s = "Hell World";

            // Act
            int result = LengthLastWord.LengthOfLastWord(s);
            int expected = 5;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LengthOfLastWordTest2()
        {
            // Arrange
            string s = "   fly me   to   the moon  ";

            // Act
            int result = LengthLastWord.LengthOfLastWord(s);
            int expected = 4;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LengthOfLastWordTest3()
        {
            // Arrange
            string s = "luffy is still joyboy";

            // Act
            int result = LengthLastWord.LengthOfLastWord(s);
            int expected = 6;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}