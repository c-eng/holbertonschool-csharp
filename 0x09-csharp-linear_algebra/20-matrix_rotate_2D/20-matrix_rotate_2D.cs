/*
using System;
using System.Collections.Generic;

///<summary>Algebraic operations on matricies.</summary>
class MatrixMath
{
    ///<summary>Rotate a matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] bad = new double[,] {{-1}};
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), -1 * Math.Sin(angle)},
                                               {Math.Sin(angle), Math.Cos(angle)}};
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
                    temp += rotate[i, k] * matrix[k, j];
                }
                matrix3[i, j] = Math.Round(temp);
            }
        }
        return (matrix3);
    }
}
*/
using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating matrix rotation</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] rotation = {
			{Math.Cos(angle), -Math.Sin(angle)},
			{Math.Sin(angle), Math.Cos(angle)}
		};
		int m_row = matrix.GetLength(0);
		int m_col = matrix.GetLength(1);

		if (2 == m_row)
		{
			double[,] result = new double[2, m_col];
			for (int i = 0; i < m_row; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < m_col; k++)
					{
						result[i, j] += Math.Round(rotation[i, k] * matrix[k, j]);
					}
				}
			}
			return result;
		}
		return new double[,] { { -1 } };
	}
}