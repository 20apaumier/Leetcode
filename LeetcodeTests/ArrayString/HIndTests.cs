using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString.Tests
{
    [TestClass()]
    public class HIndTests
    {
        [TestMethod()]
        public void HIndexTest()
        {
            // Arrange
            int[] citations = [3, 0, 6, 1, 5];
            HInd ind = new HInd();

            // Act
            int result = ind.HIndex(citations);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void HIndexTest2()
        {
            // Arrange
            int[] citations = [1, 3, 1];
            HInd ind = new HInd();

            // Act
            int result = ind.HIndex(citations);
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}