//my class
using System;

public class HowToGetAChickenDinner
{
    //pubg
    public Pubg campInCorner;
    public Pubg aggressive;
    public Pubg lowCrawling;
    public Pubg Sneaky;

    //fortnight
    public FortNight bushcamp;
    public FortNight constantRunning;
    public FortNight campInOneWayRoom;
    public FortNight sneaky;

    //Population one
    public PopulationOne houseCamp;
    public PopulationOne areaLooter;
    public PopulationOne climeTowerCamp;
    public PopulationOne Hunting;
    public void Main()
    {
        //pubg
        campInCorner = new Pubg();
        aggressive = new Pubg ();
        lowCrawling = new Pubg ();
        Sneaky = new Pubg ();

        campInCorner.deaths = 10;
        campInCorner.kills = 4;
        campInCorner.winnerWinnerChickenDinner = 0;

        aggressive.deaths = 43;
        aggressive.kills = 23;
        aggressive.winnerWinnerChickenDinner = 6;

        lowCrawling.deaths = 62;
        lowCrawling.kills = 13;
        lowCrawling.winnerWinnerChickenDinner = 1;

        Sneaky.deaths = 32;
        Sneaky.kills = 20;
        Sneaky.winnerWinnerChickenDinner = 9;

       Console.WriteLine("Pubg kill/death and win/death ratio");
        Console.WriteLine("Camping in the corner strat");
        Console.WriteLine("kill/death ratio, "+ campInCorner.kills + "/"+ campInCorner.deaths);
        Console.WriteLine("Win/lose ratio, "+ campInCorner.winnerWinnerChickenDinner + "/" + campInCorner.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Playing aggressivly");
        Console.WriteLine("kill/death ratio, "+ aggressive.kills + "/"+ aggressive.deaths);
        Console.WriteLine("Win/lose ratio, "+ aggressive.winnerWinnerChickenDinner  + "/" + aggressive.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Lowcrawling the entire game");
        Console.WriteLine("kill/death ratio, "+ lowCrawling.kills + "/"+ lowCrawling.deaths);
        Console.WriteLine("Win/lose ratio, "+ lowCrawling.winnerWinnerChickenDinner + "/" + lowCrawling.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Playing carfully");
        Console.WriteLine("kill/death ratio, "+ Sneaky.kills + "/"+ Sneaky.deaths);
        Console.WriteLine("Win/lose ratio, "+ Sneaky.winnerWinnerChickenDinner  + "/" + Sneaky.deaths);
        Console.WriteLine(" ");

        //fornight
        bushcamp = new FortNight();
        constantRunning = new FortNight();
        campInOneWayRoom = new FortNight();
        sneaky = new FortNight();

        //population one
        houseCamp = new PopulationOne();
        areaLooter = new PopulationOne();
        climeTowerCamp = new PopulationOne();
        Hunting = new PopulationOne();
    }
}
public class Pubg
{
    public int deaths;
    public int kills;
    public int winnerWinnerChickenDinner;
}
public class FortNight
{
    public int deaths;
    public int kills;
    public int victoryRoyal;
}
public class PopulationOne
{
    public int deaths;
    public int kills;
    public int victory;
}




//free style