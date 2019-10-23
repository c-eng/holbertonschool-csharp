using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Sum of two matricies.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] bad = new double[,] {{-1}};
        int height = matrix1.GetLength(0);
        int width = matrix1.GetLength(1);
        double[,] matrix3;

        if (height == 2 && width == 2 &&
            height == matrix2.GetLength(0) && width == matrix2.GetLength(1))
                matrix3 = new double[2, 2];
        else if (height == 3 && width == 3 &&
                height == matrix2.GetLength(0) && width == matrix2.GetLength(1))
                matrix3 = new double[3, 3];
        else
            return (bad);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return (matrix3);
    }
}
