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
    }
}