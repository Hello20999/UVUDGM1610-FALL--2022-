using System;

public class SwitchesPractice
{
    public gameStates GameStates;
    public void Main()
    {
        GameStates = new gameStates ();
        GameStates.checkedStates();
    }
}

public class gameStates
{
    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    public States currentStates = States.Starting;
    
    public void checkedStates ()
    {
        switch (currentStates)
        {
            case States.Starting:
            Console.WriteLine("starting");
            break;
        }
    }
}