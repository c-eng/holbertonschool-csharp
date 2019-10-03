using System;

///<summary>Checks types.</summary>
class Obj
{
    ///<summary>Determines if type is a subclass of another type.</summary>
    ///<return>True or False.</return>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
