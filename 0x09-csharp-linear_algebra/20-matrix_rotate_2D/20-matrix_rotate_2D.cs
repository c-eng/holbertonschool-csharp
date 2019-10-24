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
        matrix3[0, 0] = Math.Round(rotate[0, 0] * matrix[0, 0] + rotate[1, 0] * matrix[0, 1], 2);
        matrix3[1, 0] = Math.Round(rotate[0, 0] * matrix[1, 0] + rotate[1, 0] * matrix[1, 1], 2);
        matrix3[0, 1] = Math.Round(rotate[0, 1] * matrix[0, 0] + rotate[1, 1] * matrix[0, 1], 2);
        matrix3[1, 1] = Math.Round(rotate[0, 1] * matrix[1, 0] + rotate[1, 1] * matrix[1, 1], 2);
        return (matrix3);
    }
}