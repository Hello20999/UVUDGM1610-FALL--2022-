using System;

public class TheSecondPart
{
    public static void main()
    {
        weapon[] weaponsobjs = {new weapon(), new weapon (), new weapon ()};
        weaponsobjs[1].weaponName = "Great Axe";
        weaponsobjs[1].weaponName = "Hatchet";


        for (var i=0; i < weaponsobjs.Length; i++)
        {
            weaponsobjs[i].powerLevel = 2;
        }
        foreach (var item in weaponsobjs)
        {
            Console.WriteLine(item.weaponName);
        }
        Console.WriteLine(weaponsobjs[0].weaponName);
        Console.WriteLine(weaponsobjs[0].powerLevel);

    }
}
public class weapon
{
    public string weaponName = "axe";
    public int powerLevel = 1;
}