using System;

public class Looping
{
    public void Main()
    {
        // start at four and counts down to one and stops
        int i = 4;
        do 
        {
            Console.WriteLine(i);
            i--;
        }
        while (i > 0);

        //starts at zero, counts up to four and stops
        int n = 0;
        while (n < 5) 
        {
            Console.WriteLine(n);
            n++;
        }
    }
}