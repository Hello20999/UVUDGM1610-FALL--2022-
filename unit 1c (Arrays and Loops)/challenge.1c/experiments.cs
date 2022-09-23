//this is just to test out some functions I want to try to incorporate into my challenge
using System;

public class Experimental1c
{
    public void Main()
    {
        
        //goal is to do a looping of int with a looping of array
        //goal is successful
        int i = 4;
        do 
        {
            string[] test = {"test 1", "test 2", "test 3"};
        foreach (var testing in test)
            Console.WriteLine(i + " " + testing);
            i--;
        }
        while (i > 0);

        //goal is to do a loop with same loop
        //goal is successful
        int p = 4;
        do 
        {
            Console.WriteLine(p + " " + p);
            p--;
        }
        while (p > 0);

        //goal is to try to do an if statement on a string[]
        //goal was unsuccessful, here is what I tried:
        //string[] number = {"1", "2", "3"};
        //if (number = {"1", "2", "3"})           tried it with both {} [] and ()
        //{
        //    Console.WriteLine("works");
        //}
    }
}