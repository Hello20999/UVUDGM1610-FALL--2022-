using System;

public class VoidPractice
{
    public void Main()
    {
        Console.WriteLine("welcome");
        DoMath(10, 4);
        DoMath(20, 7);
        DoMath(30, 15);
        Compare(7,8);
        Compare(8,7);
        CheckPassword("no");
        CheckPassword("why");
    }
    public void DoMath(int value, int value2)
    {
        var number = value + value2;
        Console.WriteLine(number);
    }
    public void Compare(int value, int value2)
    {
        if (value > value2)
        {
            Console.WriteLine("True, the first is greater.");
        }
        else
        {
            Console.WriteLine("False, the second is greater.");
        }
    }
    public void CheckPassword(string password)
    {
        if (password == "why")
        {
            Console.WriteLine("correct password.");
        }
        else
        {
            Console.WriteLine("Incorrect password");
        }
    }
}