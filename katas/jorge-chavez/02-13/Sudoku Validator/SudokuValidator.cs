using System.Collections.Generic;
using System.Linq;

public class SudokuValidator
{
    public static bool Validate(int[][] board)
    {
        // Validate rows
        for (int i = 0; i < 9; i++)
        {
            // Validate columns
            int[] columnArray = new int[9];
            for (int j = 0; j < 9; j++)
            {
                columnArray[j] = board[j][i];
            }
            if (
                board[i].Distinct().Count() != 9
                || board[i].Sum() != 45
                || columnArray.Distinct().Count() != 9
                || columnArray.Sum() != 45
            )
            {
                return false;
            }
        }
        // Validate Quadrant
        var column = 0;
        var row = 0;
        var sumQuadrant = 0;
        while (column < 9)
        {
            while (row < 9)
            {
                for (int i = row; i < row + 3; i++)
                {
                    for (int j = column; j < column + 3; j++)
                    {
                        sumQuadrant += board[i][j];
                    }
                }
                if (sumQuadrant != 45)
                {
                    return false;
                }
                sumQuadrant = 0;
                row += 3;
            }
            sumQuadrant = 0;
            column += 3;
            row = 0;
        }

        return true;
    }
}
