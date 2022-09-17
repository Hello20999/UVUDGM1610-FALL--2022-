using System;

public class CookingFrenchToast
{
    public void Main()
    {
        Console.WriteLine("guess the equation");
        int first = 2;
        int second = 2;
        string type = "Plus";

        switch (type)
        {
            case "plus":
            int Plus = first + second;
            break;
            case "Subtract":
            int Subtract = first - second;
            break;
            case "Devide":
            int Devide = first / second;
            break;
            case "Multiply":
            int Multiply = first * second;
            break;
        }
    }
}