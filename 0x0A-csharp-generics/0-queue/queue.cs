using System;

///<summary>Generic queue class implementation.</summary>
public class Queue<T>
{
    ///<summary>Checks type of parameter.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}