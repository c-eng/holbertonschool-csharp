using System;
using System.Collections.Generic;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Dot product of two vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot = -1;

        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            dot = 0;
            for (int i = 0; i < vector1.Length; i++)
                dot += (vector1[i] * vector2[i]);
        }
        return (dot);
    }
}
