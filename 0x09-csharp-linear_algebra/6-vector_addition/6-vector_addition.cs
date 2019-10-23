using System;
using System.Collections.Generic;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Adds two vectors.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vector3 = new double[1] {-1};

        if (vector1.Length == 2 && vector1.Length == vector2.Length)
        {
            vector3 = new double[2] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
        }
        else if (vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            vector3 = new double[3] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2]+vector2[2]};
        }
        return (vector3);
    }
}
