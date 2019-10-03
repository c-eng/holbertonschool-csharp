using System;

///<summary>Checks types.</summary>
class Obj
{
    ///<summary>Determines if type is int.</summary>
    ///<return>True or False.</return>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}
