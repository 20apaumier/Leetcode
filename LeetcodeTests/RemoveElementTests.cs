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
    public class RemoveElementTests
    {
        [TestMethod()]
        public void RemoveTest()
        {
            // arrange
            int[] nums = [3, 2, 2, 3];
            int val = 3;

            // act
            int result = RemoveElement.Remove(nums, val);
            int expected = 2;

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RemoveTest2()
        {
            // arrange
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;

            // act
            int result = RemoveElement.Remove(nums, val);
            int expected = 5;

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}