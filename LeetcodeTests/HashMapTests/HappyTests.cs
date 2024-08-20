using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.HashMap;

namespace LeetcodeTests.HashMapTests
{
    [TestClass()]
    public class HappyTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            // Arrange
            int n = 19;

            // Act
            bool result = Happy.IsHappy(n);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsHappyTest2()
        {
            // Arrange
            int n = 2;

            // Act
            bool result = Happy.IsHappy(n);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}