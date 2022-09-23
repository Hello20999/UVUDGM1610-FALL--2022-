using System;

public class arrayVideo
{
    public void Main()
    {
        //arrays
        string[] burger = {"burger", "Hamburger", "Cheeseburger", "Bacon burger"};
        Console.WriteLine(burger.Length);
        Console.WriteLine(burger [0]);
        Console.WriteLine(burger [1]);
        Console.WriteLine(burger [2]);
        Console.WriteLine(burger [3]);
        foreach (var sandwhich in burger)
        {
            Console.WriteLine("How to eat a " + sandwhich);
        }

        //multiple
        string[] pizza = {"cheese", "cheese", "cheese"};
        for (var i = 0; i < pizza.Length; i++)
        {
            pizza[i] = "tomato";
        }
        foreach (var pizzas in pizza)
        {
            Console.WriteLine("Now the tables haved turned to " + pizzas);
        }

        //just one change
        string[] lazer = {"cheese", "cheese", "cheese"};
        lazer[1] = "tomato";
        foreach (var lazers in lazer)
        {
            Console.WriteLine("Now the tables haved turned to " + lazers);
        }
    }
}