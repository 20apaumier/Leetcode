using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Matrix
{
    public class Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char> visited = new HashSet<char>();

            // verify 3 things
            // Check rows
            for (int i = 0; i < 9; i++)
            {
                visited.Clear();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (visited.Contains(board[i][j]))
                        {
                            return false; // duplicate in the row
                        }
                        visited.Add(board[i][j]);
                    }
                }
            }

            // Check columns
            for (int j = 0; j < 9; j++)
            {
                visited.Clear();
                for (int i = 0; i < 9; i++)
                {
                    if (board[i][j] != '.')
                    {
                        if (visited.Contains(board[i][j]))
                        {
                            return false; // duplicate in the column
                        }
                        visited.Add(board[i][j]);
                    }
                }
            }

            // Check 3x3 sub-boxes
            for (int boxRow = 0; boxRow < 9; boxRow += 3)
            {
                for (int boxCol = 0; boxCol < 9; boxCol += 3)
                {
                    visited.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            char currentChar = board[boxRow + i][boxCol + j];
                            if (currentChar != '.')
                            {
                                if (visited.Contains(currentChar))
                                {
                                    return false; // duplicate in the sub-box
                                }
                                visited.Add(currentChar);
                            }
                        }
                    }
                }
            }

            // If no duplicates found, the board is valid
            return true;
        }
    }
}
