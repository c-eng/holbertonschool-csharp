using System;
using System.Collections.Generic;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Calculates magnitude from component vectors.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return (Math.Round(Math.Sqrt(vector[0]*vector[0]+vector[1]*vector[1]), 2));
        }
        if (vector.Length == 3)
        {
            return (Math.Round(Math.Sqrt(vector[0]*vector[0]+vector[1]*vector[1]+vector[2]*vector[2]), 2));
        }
        return (-1);
    }
}
