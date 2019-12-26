using System;

///<summary>Calculation modifiers.</summary>
public enum Modifier
{
    ///<summary>Weak modifier</summary>
    Weak = 1,
    ///<summary>Base modifier</summary>
    Base = 2,
    ///<summary>Strong modifier</summary>
    Strong = 3
}

delegate void CalculateHealth(float health);
///<summary>Calculates modifiers.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Constructor for Player class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Prints Player health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health.");
    }

    ///<summary>Calculates Player damage.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        float newHp = this.hp - damage;
        this.ValidateHP(newHp);
    }

    ///<summary>Calculates Player healing.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
            heal = 0f;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        float newHp = this.hp + heal;
        this.ValidateHP(newHp);
    }

    ///<summary>Validates Player health modification.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    ///<summary>Validates Player health modification.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return (baseValue * ((float)modifier / 2f));
    }
}
