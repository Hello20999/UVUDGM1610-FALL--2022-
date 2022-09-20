using System;

public class NightOne
{
    public void Main()
    {
        string[] people = {"Steve", "Sam", "Sanders", "Sofia", "Samuel", "Scarlet", "sophia"};
        foreach (var names in people)
        Console.WriteLine("It was a beutiful evening in the castle, where " + names + " fell asleep.");
        Console.WriteLine("Most people thought it would be a nice night, but no one could of predicted the tragedy that would have occured.");
        people[2] = "Sanders did not";
        foreach (var steve in people)
        Console.WriteLine("For when the sun arised," + steve + " awaken from their sleep");
    }
}