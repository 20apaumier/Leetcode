using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass]
    public class AnagraTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // act
            bool result = Anagra.IsAnagram(s, t);
            bool expected = true;

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsAnagramTest2()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // act
            bool result = Anagra.IsAnagram(s, t);
            bool expected = false;

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}