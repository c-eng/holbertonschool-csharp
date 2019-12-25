using System;
using System.Collections;
using System.Collections.Generic;

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{

    public Door(string nm = "Door")
    {
        name = nm;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string nm = "Decoration", int db = 1, bool qt = false)
    {
        if (db < 1)
            throw new System.ArgumentException("Durability must be greater than 0");
        name = nm;
        durability = db;
        isQuestItem = qt;
    }
    public void Interact()
    {
        if (durability < 1)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}

class Key : Base, ICollectable
{

    public bool isCollected { get; set; }

    public Key(string nm = "Key", bool cl = false)
    {
        name = nm;
        isCollected = cl;
    }
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {name}.");
    }
}

class Objs<T> : IEnumerable<T>
{
    List<T> objs = new List<T>();

    public void Add(T obj)
    {
        objs.Add(obj);
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T obj in objs)
        {
            yield return (obj);
        }
    }
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}
}