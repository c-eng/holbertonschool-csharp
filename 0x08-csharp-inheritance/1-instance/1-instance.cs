using System;

///<summary>Checks types.</summary>
class Obj
{
    ///<summary>Determines if is an instance of array.</summary>
    ///<return>True or False.</return>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
