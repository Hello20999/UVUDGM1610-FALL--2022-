using System;

public class VoidPractice1
{
    public void Main()
    {
       //if
       if (20 > 18)    
       {
         Console.WriteLine("20 is greater than 18");
       }
         int x = 20;
         int y = 18;
         if (x > y) 
         {
            Console.WriteLine("x is greater than y");
            }

            //else
            int time = 6;
            if (time < 18) 
            {
                Console.WriteLine("Good day.");
                } 
                else 
                {
                    Console.WriteLine("Good evening.");
        }

        //else if
        int timez = 2;
if (timez < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (timez < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

//other if
    int times = 16;
string result = (times < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);    
    }
}