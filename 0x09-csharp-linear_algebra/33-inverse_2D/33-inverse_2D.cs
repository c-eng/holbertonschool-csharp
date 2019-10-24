using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Inverse of a matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] bad = new double[,] {{-1}};
        double det;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (det == 0)
                return (bad);
            double[,] inverse = new double[,] {
                {(1 / det) * matrix[1, 1], (1 / det) * -matrix[0, 1]},
                {(1 / det) * -matrix[1, 0], (1 / det) * matrix[0, 0]}
            };
            return (inverse);
        }
        return (bad);
    }
}