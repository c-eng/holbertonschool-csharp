using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Sum of two matricies.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] bad = new double[,] {{-1}};
        double[,] matrix3;
        int match = matrix1.GetLength(1);
        double temp;

        if (match == matrix2.GetLength(0))
            matrix3 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        else
            return (bad);
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                temp = 0;
                for (int k = 0; k < match; k++)
                {
                    temp += matrix1[i, k] * matrix2[k, j];
                }
                matrix3[i, j] = temp;
            }
        }
        return (matrix3);
    }
}
