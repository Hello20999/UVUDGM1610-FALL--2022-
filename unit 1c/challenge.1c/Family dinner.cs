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
        Console.WriteLine("the next day, the " + food [1] + " and " + food [2] + " were all cooked");
        food[1] = "Turkey";
        food[2] = "Ham";
        Console.WriteLine("but the " + food [0] + " went bad, so you threw it out");
        food[0] = "spoiled Mashed Potato";
        Console.WriteLine("other than that, you begin to eat the food");
        int z = 5;
        do 
        {
            Console.WriteLine("there were the " + food [0] + ", and "+ z + " "+ food[1] + ", and "+ z + " "+ food[2] + ", and "+ z + " "+ food[3] + ", and "+ z + " "+ food[4] + " and you ate one of each");
            z--;
        }
        while (z > 0);
        Console.WriteLine ("After you eat the last of what there is, and throw out the remaining " + food[0]);
        for (var w = 0; w < food.Length; w++)
        {
            food[w] = "nothing left";
        }
        Console.WriteLine("you check to see what you have left");
        foreach (var pineapple in food)
        Console.WriteLine("you have " + pineapple);
        Console.WriteLine("Which concludes thanksgiving night");
    }
}