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
    public class RandomTests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "b";

            // Act
            bool result = Random.CanConstruct(ransomNote, magazine);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CanConstructTest2()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            bool result = Random.CanConstruct(ransomNote, magazine);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CanConstructTest3()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "aab";

            // Act
            bool result = Random.CanConstruct(ransomNote, magazine);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CanConstructTest4()
        {
            // Arrange
            string ransomNote = "sos";
            string magazine = "pasosap";

            // Act
            bool result = Random.CanConstruct(ransomNote, magazine);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}