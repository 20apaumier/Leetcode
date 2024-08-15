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
    public class IsomorphicTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            // Arrange
            string s = "egg";
            string t = "add";

            // Act
            bool result = Isomorphic.IsIsomorphic(s, t);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest2()
        {
            // Arrange
            string s = "foo";
            string t = "bar";

            // Act
            bool result = Isomorphic.IsIsomorphic(s, t);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest3()
        {
            // Arrange
            string s = "paper";
            string t = "title";

            // Act
            bool result = Isomorphic.IsIsomorphic(s, t);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest4()
        {
            // Arrange
            string s = "badc";
            string t = "baba";

            // Act
            bool result = Isomorphic.IsIsomorphic(s, t);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}