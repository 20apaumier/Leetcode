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
    public class JumpGameTests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            // arrange
            int[] nums = [2, 3, 1, 1, 4];
            JumpGame jg = new JumpGame();

            // act
            bool result = jg.CanJump(nums);
            bool expected = true;

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CanJumpTest2()
        {
            // arrange
            int[] nums = [3, 2, 1, 0, 4];
            JumpGame jg = new JumpGame();

            // act
            bool result = jg.CanJump(nums);
            bool expected = false;

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}