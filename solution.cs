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