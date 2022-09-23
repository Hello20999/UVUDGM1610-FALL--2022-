using System;

public class FamilyDinner
{
    public void Main()
    {
        Console.WriteLine("It twas the night before thanksgiving");
        Console.WriteLine("and a feast had to be made");
        String[] food = {"Mashed Potato", "uncooked Turkey", "uncooked Ham", "Stuffing", "Jello"};
        foreach (var turykeys in food)
        Console.WriteLine("you made " + turykeys);
        Console.WriteLine("but one wouldn't be enough, you need more");
        int i = 2;
        do 
        {
            foreach (var potato in food)
            Console.WriteLine("so you made " + i + " " + potato);
            i++;
        }
        while (i < 6);
        Console.WriteLine("thats all you need, so you stop cooking");
        Console.WriteLine("the next day, the " + food [2] + " and " + food [3] + " were all cooked");
        for (var l = 2; l < food.Length; l++)
        {
            food[l] = "Turkey";
        }
        for (var s = 3; s < food.Length; s++)
        {
            food[s] = "Ham";
        }
    }
}