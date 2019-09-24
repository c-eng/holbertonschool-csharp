using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int num = myLList.First.Value;
        myLList.RemoveFirst();
        return (num);
    }
}
