using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Matrix.Tests
{
    [TestClass()]
    public class SpiralTests
    {
        [TestMethod()]
        public void SpiralOrderTest()
        {
            // Arrange
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            Spiral s = new Spiral();

            // Act
            IList<int> expected = [1, 2, 3, 6, 9, 8, 7, 4, 5];
            IList<int> result = s.SpiralOrder(matrix);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }

        [TestMethod()]
        public void SpiralOrderTest2()
        {
            // Arrange
            int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];
            Spiral s = new Spiral();

            // Act
            IList<int> expected = [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7];
            IList<int> result = s.SpiralOrder(matrix);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }
    }
}