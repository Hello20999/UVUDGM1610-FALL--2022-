using System;

public class Arrays3
{
    public void Main()
    {
        //choosing one in a list, the zero chooses the first listed item.
        string[] planes = {"Delta", "Alaskan", "American"};
        Console.WriteLine(planes[0]);

        //changing a name of an item in a list
        string[] xbox = {"Xbox", "Xbox360", "Xbox one", "Xbox series"};
        xbox[2] = "Playstations";
        Console.WriteLine(xbox[2]);

        //knowing a legth of a list in a 8 item list
        string[] spaceGames = {"OuterWilds", "StarBound", "Deep Rock Galatic", "Halo", "Stellarus", "Universe Sand Box", "War Frame", "Destiny 2"};
        Console.WriteLine(spaceGames.Length);

        //Using a loop with a list
        string[] minecraft = {"Steve", "Alex", "Enderman", "Zombie"};
        for (int i = 0; i < minecraft.Length; i++) 
        {
            Console.WriteLine(minecraft[i]);
        }
    }
}