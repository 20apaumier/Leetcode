using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.ArrayString;

namespace LeetcodeTests.ArrayStringTests
{
    [TestClass()]
    public class MajorityElementTests
    {
        [TestMethod()]
        public void MajorityTest()
        {
            // Arrange 
            int[] nums = [3, 2, 3];

            // Act
            int result = MajorityElement.Majority(nums);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MajorityTest2()
        {
            // Arrange 
            int[] nums = [4, 4, 4, 5, 5, 5, 5];

            // Act
            int result = MajorityElement.Majority(nums);
            int expected = 5;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MajorityTest3()
        {
            // Arrange 
            int[] nums = [2, 2, 1, 1, 1, 2, 2];

            // Act
            int result = MajorityElement.Majority(nums);
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void MajorityTestWithTup()
        {
            // Arrange 
            int[] nums = [3, 2, 3];

            // Act
            int result = MajorityElement.MajorityWithTup(nums);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MajorityTest2WithTup()
        {
            // Arrange 
            int[] nums = [4, 4, 4, 5, 5, 5, 5];

            // Act
            int result = MajorityElement.MajorityWithTup(nums);
            int expected = 5;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MajorityTest3WithTup()
        {
            // Arrange 
            int[] nums = [2, 2, 1, 1, 1, 2, 2];

            // Act
            int result = MajorityElement.MajorityWithTup(nums);
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}