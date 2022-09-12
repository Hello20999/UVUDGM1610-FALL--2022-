using System;

public class VoidPractice
{
    public void Main()
    {
        Console.WriteLine("welcome");
        DoMath(10);
        DoMath(20);
        DoMath(30);
    }
    public void DoMath(int value)
    {
        var number = value + 2;
        Console.WriteLine(number);
    }
}