using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Tests
{
    [TestClass()]
    public class MostWaterTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            // Arrange
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            MostWater mw = new MostWater();

            // Act
            int expected = 49;
            int result = mw.MaxArea(height);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MaxAreaTest2()
        {
            // Arrange
            int[] height = [2, 3, 4, 5, 18, 17, 6];
            MostWater mw = new MostWater();

            // Act
            int expected = 17;
            int result = mw.MaxArea(height);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}