```C#
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[,] board = new int[9, 9]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };

        Console.WriteLine(IsValidSudoku(board) ? "Valid" : "Invalid");
    }

    static bool IsValidSudoku(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidRow(board, i) || !IsValidColumn(board, i))
            {
                return false;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!IsValidBox(board, i * 3, j * 3))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool IsValidRow(int[,] board, int row)
    {
        bool[] visited = new bool[9];
        for (int i = 0; i < 9; i++)
        {
            if (visited[board[row, i] - 1])
            {
                return false;
            }

            visited[board[row, i] - 1] = true;
        }

        return true;
    }

    static bool IsValidColumn(int[,] board, int column)
    {
        bool[] visited = new bool[9];
        for (int i = 0; i < 9; i++)
        {
            if (visited[board[i, column] - 1])
            {
                return false;
            }

            visited[board[i, column] - 1] = true;
        }

        return true;
    }

    static bool IsValidBox(int[,] board, int startRow, int startCol)
    {
        bool[] visited = new bool[9];
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                int num = board[row + startRow, col + startCol];
                if (visited[num - 1])
                {
                    return false;
                }

                visited[num - 1] = true;
            }
        }

        return true;
    }
}
```