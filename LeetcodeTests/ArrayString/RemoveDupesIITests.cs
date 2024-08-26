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
    public class RemoveDupesIITests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            // Arrange
            int[] nums = [1, 1, 1, 2, 2, 3];

            RemoveDupesII rd = new RemoveDupesII();

            // Act
            int result = rd.RemoveDuplicates(nums);
            int expected = 5;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RemoveDuplicatesTest2()
        {
            // Arrange
            int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];

            RemoveDupesII rd = new RemoveDupesII();

            // Act
            int result = rd.RemoveDuplicates(nums);
            int expected = 7;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}