using System;

public class VoidPractice
{
    public void Main()
    {
        Console.WriteLine("welcome");
        DoMath(10, 4);
        DoMath(20, 7);
        DoMath(30, 15);
    }
    public void DoMath(int value, int value2)
    {
        var number = value + value2;
        Console.WriteLine(number);
    }
}