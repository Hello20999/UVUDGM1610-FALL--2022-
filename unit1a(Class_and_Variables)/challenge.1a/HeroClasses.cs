//hero classes
using System;

public class program
{
    public Hero heroOne;
    public Hero heroTwo;
    public Hero heroThree;
    public Hero herofour;
    public Villian villian;
    
    public void Main( )
    {
        //heros
        heroOne = new Hero();
        heroTwo = new Hero();
        heroThree = new Hero();
        herofour = new Hero();
        
        heroOne.health = 2;
        heroOne.powerLevel = 4;
        heroOne.stamina = 10;
        heroOne.Mana = 2;
        heroOne.spellLevel = 6;
        heroOne.WeaponLevel = 1;
        heroOne.level = heroOne.WeaponLevel + heroOne.spellLevel + heroOne.powerLevel;
        
        heroTwo.health = 4;
        heroTwo.powerLevel = 1;
        heroTwo.stamina = 2;
        heroTwo.Mana = 10;
        heroTwo.spellLevel = 1;
        heroTwo.WeaponLevel = 8;
        heroTwo.level = heroTwo.WeaponLevel + heroTwo.spellLevel + heroTwo.powerLevel;

        heroThree.health = 7;
        heroThree.powerLevel = 7;
        heroThree.stamina = 2;
        heroThree.Mana = 10;
        heroThree.spellLevel = 2;
        heroThree.WeaponLevel = 2;
        heroThree.level = heroThree.WeaponLevel + heroThree.spellLevel + heroThree.powerLevel;

        herofour.health = 7;
        herofour.powerLevel = 4;
        herofour.stamina = 2;
        herofour.Mana = 4;
        herofour.spellLevel = 4;
        herofour.WeaponLevel = 4;
        herofour.level = herofour.WeaponLevel + herofour.spellLevel + herofour.powerLevel;
        
        Console.WriteLine("Hero One stats");
        Console.WriteLine("health: " + heroOne.health + "                       Stamina: " + heroOne.stamina + "                           Mana: " + heroOne.Mana);
        Console.WriteLine("Power Level: " + heroOne.powerLevel + "                  Spell Level: " + heroOne.spellLevel + "                        Weapon Level: " + heroOne.WeaponLevel);
        Console.WriteLine("level: " + heroOne.level);

        Console.WriteLine(" ");
        Console.WriteLine("Hero Two stats");
        Console.WriteLine("health: " + heroTwo.health + "                       Stamina: " + heroTwo.stamina + "                           Mana: " + heroTwo.Mana);
        Console.WriteLine("Power Level: " + heroTwo.powerLevel + "                  Spell Level: " + heroTwo.spellLevel + "                        Weapon Level: " + heroTwo.WeaponLevel);
        Console.WriteLine("level: " + heroTwo.level);

        Console.WriteLine(" ");
        Console.WriteLine("Hero Three stats");
        Console.WriteLine("health: " + heroThree.health + "                       Stamina: " + heroThree.stamina + "                           Mana: " + heroThree.Mana);
        Console.WriteLine("Power Level: " + heroThree.powerLevel + "                  Spell Level: " + heroThree.spellLevel + "                        Weapon Level: " + heroThree.WeaponLevel);
        Console.WriteLine("level: " + heroThree.level);
        
        Console.WriteLine(" ");
        Console.WriteLine("Hero Four stats");
        Console.WriteLine("health: " + herofour.health + "                       Stamina: " + herofour.stamina + "                           Mana: " + herofour.Mana);
        Console.WriteLine("Power Level: " + herofour.powerLevel + "                  Spell Level: " + herofour.spellLevel + "                        Weapon Level: " + herofour.WeaponLevel);
        Console.WriteLine("level: " + herofour.level);

        //villians
        villian = new Villian();

        villian.enemyPowerLevel = (heroOne.level + heroTwo.level + heroThree.level + herofour.level) / 4;
        villian.enemyHealth = (heroOne.health + heroTwo.health + heroThree.health + herofour.health / 4) * 4;
        villian.basicAttack = 6;
        villian.specialOne = 2;
        villian.specialTwo = 1;

        Console.WriteLine(" ");
        Console.WriteLine("The Villian");
        Console.WriteLine("Power level: " + villian.enemyPowerLevel);
        Console.WriteLine("Health: " + villian.enemyHealth);
        Console.WriteLine("basic attack deals " + villian.basicAttack + " damage");
        Console.WriteLine("Breath fire, deals "+ villian.specialOne + " damage");
        Console.WriteLine("Electricute surrondings, deals " + villian.specialTwo + " damage");
    }
}

public class Hero
{
    public int health;
    public int powerLevel;
    public int Mana;
    public int spellLevel;
    public int WeaponLevel;
    public int stamina;
    public int level;
}
public class Villian
{
    public int enemyHealth;
    public int enemyPowerLevel;
    public int specialOne;
    public int specialTwo;
    public int basicAttack;
}