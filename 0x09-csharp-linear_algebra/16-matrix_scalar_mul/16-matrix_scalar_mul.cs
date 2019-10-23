using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Scale a matrix.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] bad = new double[,] {{-1}};
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);
        double[,] matrix3;

        if (height == 2 && width == 2)
                matrix3 = new double[2, 2];
        else if (height == 3 && width == 3)
                matrix3 = new double[3, 3];
        else
            return (bad);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                matrix3[i, j] = matrix[i, j] * scalar;
            }
        }
        return (matrix3);
    }
}
