using System;

public class CookingFrenchToast
{
    public void Main()
    {
        Console.WriteLine("guess the equation");

        //change value
        int first = 2;
        int second = 2;

        //change to "Add", "Subtract", "Devide", "Multiply".  Each has a diffrent correct answer behind it.
        string type = "Add";


//Answers are revealed past this point



        switch (type)
        {
            //add
            case "Add":
            int Add = first + second;
            Console.WriteLine (first + "+" + second + "=" + Add);
            if (Add < 2)
            {
                Console.WriteLine("Too low of an outcome");
            }
            else if (Add > 2)
            {
                Console.WriteLine("Too high of an outcome");
            }
            else
            {
                if (first > 0)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else if (first < 0)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else
                {
                    if (second > 2)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else if (second < 2)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the addition equation correctly");
                    }
            }
            }
            break;
            
            //subtract
            case "Subtract":
            int Subtract = first - second;
            Console.WriteLine (first + "-" + second + "=" + Subtract);
            if (Subtract < 5)
            {
                Console.WriteLine("Too low of an outcome");
            }
            else if (Subtract > 5)
            {
                Console.WriteLine("Too high of an outcome");
            }
            else
            {
                if (first > 37)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else if (first < 37)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else
                {
                    if (second > 32)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else if (second < 32)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the Subtraction equation correctly");
                    }
                }
            }
            break;
            
            //devide
            case "Devide":
            int Devide = first / second;
            Console.WriteLine (first + "/" + second + "=" + Devide);
            if (Devide < 9)
            {
                Console.WriteLine("Too low of an outcome");
            }
            else if (Devide > 9)
            {
                Console.WriteLine("Too high of an outcome");
            }
            else
            {
                 if (first > 117)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else if (first < 117)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else
                {
                    if (second > 13)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else if (second < 13)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the Deviding equation correctly");
                    }
                }
            }
            break;
            
            //multiply
            case "Multiply":
            int Multiply = first * second;
            Console.WriteLine (first + "*" + second + "=" + Multiply);
            if (Multiply < 1188)
            {
                Console.WriteLine("Too low of an outcome");
            }
            else if (Multiply > 1188)
            {
                Console.WriteLine("Too high of an outcome");
            }
            else
            {
                if (first > 33)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else if (first < 33)
                {
                    Console.WriteLine("One or both of the numbers is wrong");
                }
                else
                {
                    if (second > 36)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else if (second < 36)
                    {
                        Console.WriteLine("One or both of the numbers is wrong");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the Multiplying equation correctly");
                    }
                }
            }
            break;
        }
    }
}