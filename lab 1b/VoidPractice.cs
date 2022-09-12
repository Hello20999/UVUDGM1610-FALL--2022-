using System;

public class VoidPractice
{
    public operation myoperator;
    public void Main()
    {
        myoperator = new operation();

        Console.WriteLine("welcome");
        myoperator.DoMath(10, 4);
        myoperator.DoMath(20, 7);
        myoperator.DoMath(30, 15);
        myoperator.Compare(7,8);
        myoperator.Compare(8,7);
        myoperator.CheckPassword("no");
        myoperator.CheckPassword("why");
    }
}
public class operation
{
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

