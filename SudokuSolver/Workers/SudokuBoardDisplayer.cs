using System;

namespace SudokuSolver.Workers
{
    class SudokuBoardDisplayer
    {
        public void Display(string title, int[,] sudokuBoard)
        {
            // if (!title.Equals(string.Empty))
            if (!string.IsNullOrEmpty(title))
            {
                Console.WriteLine(title + Environment.NewLine);
                for (int row = 0; row < sudokuBoard.GetLength(0); row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                    {
                        Console.WriteLine($"{sudokuBoard[row, col]}|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
