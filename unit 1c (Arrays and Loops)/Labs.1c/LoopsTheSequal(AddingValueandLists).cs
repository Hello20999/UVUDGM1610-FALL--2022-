using System;

public class Loops2
{
    public void Main()
    {
       //taking away 1 from 3 to a min of -2
       for (int i = 3; i > -2; i--) 
       {
        Console.WriteLine(i);
        } 

        //adding value by 15 to max of 1000 from 100
        for (int n = 100; n <= 1000; n = n + 15)
        {
            Console.WriteLine(n);
        }

        //showing a list of items
        string[] sports = {"soccor", "Football", "American foorball", "baseball", "vollyball"};
        foreach (string c in sports) 
        {
            Console.WriteLine(c);
        }
    }
}