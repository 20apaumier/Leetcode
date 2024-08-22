using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.BitManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BitManipulation.Tests
{
    [TestClass()]
    public class AddBinTests
    {
        [TestMethod()]
        public void AddBinaryTest()
        {
            // Arrange
            string a = "11";
            string b = "1";
            
            // Act
            string result = AddBin.AddBinary(a, b);
            string expected = "100";

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}