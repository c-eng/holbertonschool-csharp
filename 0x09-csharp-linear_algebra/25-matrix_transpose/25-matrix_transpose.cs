using System;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Transpose a matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] bad = new double[,] {{-1}};
        int fromWidth = matrix.GetLength(1);
        int fromHeight = matrix.GetLength(0);
        double[,] matrix3 = new double[fromWidth, fromHeight];

        for (int i = 0; i < fromWidth; i++)
        {
            for (int j = 0; j < fromHeight; j++)
            {
                matrix3[i, j] = matrix[j, i];
            }
        }
        return (matrix3);
    }
}