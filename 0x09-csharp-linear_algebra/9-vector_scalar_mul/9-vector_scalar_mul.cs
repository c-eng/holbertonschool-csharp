using System;
using System.Collections.Generic;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Scales a vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] vector3 = new double[1] {-1};

        if (vector.Length == 2)
        {
            vector3 = new double[2] {vector[0] * scalar, vector[1] * scalar};
        }
        else if (vector.Length == 3)
        {
            vector3 = new double[3] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
        }
        return (vector3);
    }
}
