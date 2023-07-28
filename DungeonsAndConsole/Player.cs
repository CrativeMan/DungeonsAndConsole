namespace DungeonsAndConsole;

public class Player
{
    // Properties
    public String Name { get; private set; }
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }

    // Constructor
    public Player(String name, int maxHealth, int attack, int defense, int gold, int level)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Attack = attack;
        Defense = defense;
        Gold = gold;
        Level = level;
    }
    
    //Methods
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
    
    public void AddGold(int amount)
    {
        Gold += amount;
    }
    
    public void RemoveGold(int amount)
    {
        Gold -= amount;
    }
    
    public void LevelUp()
    {
        Level++;
        MaxHealth += 10;
        Attack += 2;
        Defense += 2;
        Heal(MaxHealth);
    }
    
    public void PrintStats()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health + "/" + MaxHealth);
        Console.WriteLine("Attack: " + Attack);
        Console.WriteLine("Defense: " + Defense);
        Console.WriteLine("Gold: " + Gold);
        Console.WriteLine("Level: " + Level);
    }

}