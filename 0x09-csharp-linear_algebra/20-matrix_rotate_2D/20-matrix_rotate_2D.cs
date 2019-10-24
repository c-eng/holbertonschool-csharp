using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Rotate a matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] bad = new double[,] {{-1}};
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)},
                                               {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] matrix3 = new double[2, 2];
        double temp;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (bad);
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                temp = 0;
                for (int k = 0; k < 2; k++)
                {
                    temp += matrix[i, k] * rotate[k, j];
                }
                matrix3[i, j] = Math.Round(temp, 2);
            }
        }
        return (matrix3);
    }
}