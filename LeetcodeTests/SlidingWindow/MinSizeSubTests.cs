using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SlidingWindow.Tests
{
    [TestClass()]
    public class MinSizeSubTests
    {
        [TestMethod()]
        public void MinSubArrayLenTest()
        {
            // Arrange
            int target = 7;
            int[] nums = [2, 3, 1, 2, 4, 3];

            // Act
            MinSizeSub mss = new MinSizeSub();
            int expected = 2;
            int result = mss.MinSubArrayLen(target, nums);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}