using System;

///<summary>Generic queue class implementation.</summary>
public class Queue<T>
{
    ///<summary>Head of a queue.</summary>
    public Node head = null;
    ///<summary>Tail of a queue.</summary>
    public Node tail = null;
    int count = 0;

    ///<summary>Checks type of parameter.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
    ///<summary>Adds to a queue.</summary>
    public void Enqueue(T val)
    {
        Node neu = new Node(val);
        if (head == null && tail == null)
        {
            head = neu;
            tail = neu;
        }
        else
        {
            tail.next = neu;
            tail = neu;
        }
        count += 1;
    }
    ///<summary>Counts a queue.</summary>
    public int Count()
    {
        return (count);
    }

    ///<summary>Queue nodes.</summary>
    public class Node
    {
        ///<summary>Value of a node.</summary>
        public T value = default(T);
        ///<summary>Next node.</summary>
        public Node next = null;

        ///<summary>Constructor for Node.</summary>
        public Node (T t)
        {
            value = t;
        }
    }
}