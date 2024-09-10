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
    public class SudokuTests
    {
        [TestMethod()]
        public void IsValidSudokuTest()
        {
            // Arrange
            char[][] board = [['5','3','.','.','7', '.', '.', '.', '.']
                                ,['6', '.', '.', '1', '9', '5', '.', '.', '.']
                                ,['.', '9', '8', '.', '.', '.', '.', '6', '.']
                                ,['8', '.', '.', '.', '6', '.', '.', '.', '3']
                                ,['4', '.', '.', '8', '.', '3', '.', '.', '1']
                                ,['7', '.', '.', '.', '2', '.', '.', '.', '6']
                                ,['.', '6', '.', '.', '.', '.', '2', '8', '.']
                                ,['.', '.', '.', '4', '1', '9', '.', '.', '5']
                                ,['.', '.','.','.','8', '.', '.', '7', '9']];
            Sudoku s = new Sudoku();

            // Act
            bool expected = true;
            bool result = s.IsValidSudoku(board);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}