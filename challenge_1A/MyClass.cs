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
       Console.WriteLine(" ");
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

        bushcamp.deaths = 40;
        bushcamp.kills = 9;
        bushcamp.victoryRoyal = 0;

        constantRunning.deaths = 90;
        constantRunning.kills = 34;
        constantRunning.victoryRoyal = 13;

        campInOneWayRoom.deaths = 30;
        campInOneWayRoom.kills = 20;
        campInOneWayRoom.victoryRoyal = 3;

        sneaky.deaths = 40;
        sneaky.kills = 25;
        sneaky.victoryRoyal = 3;

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Fortnight kill/death and win/death ratio");
        Console.WriteLine(" ");
        Console.WriteLine("Camping in the corner strat");
        Console.WriteLine("kill/death ratio, "+ campInOneWayRoom.kills + "/"+ campInOneWayRoom.deaths);
        Console.WriteLine("Win/lose ratio, "+ campInOneWayRoom.victoryRoyal + "/" + campInOneWayRoom.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Playing aggressivly");
        Console.WriteLine("kill/death ratio, "+ constantRunning.kills + "/"+ constantRunning.deaths);
        Console.WriteLine("Win/lose ratio, "+ constantRunning.victoryRoyal  + "/" + constantRunning.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Bush camp the entire game");
        Console.WriteLine("kill/death ratio, "+ bushcamp.kills + "/"+ bushcamp.deaths);
        Console.WriteLine("Win/lose ratio, "+  bushcamp.victoryRoyal + "/" + bushcamp.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Playing carfully");
        Console.WriteLine("kill/death ratio, "+ sneaky.kills + "/"+ sneaky.deaths);
        Console.WriteLine("Win/lose ratio, "+ sneaky.victoryRoyal  + "/" + sneaky.deaths);
        Console.WriteLine(" ");

        //population one
        houseCamp = new PopulationOne();
        areaLooter = new PopulationOne();
        climeTowerCamp = new PopulationOne();
        Hunting = new PopulationOne();

        houseCamp.deaths = 12;
        houseCamp.kills = 3;
        houseCamp.victory = 2;

        areaLooter.deaths = 24;
        areaLooter.kills = 23;
        areaLooter.victory = 7;

        climeTowerCamp.deaths = 4;
        climeTowerCamp.kills = 13;
        climeTowerCamp.victory = 5;

        Hunting.deaths = 42;
        Hunting.kills = 31;
        Hunting.victory = 8;

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Population kill/death and win/death ratio");
        Console.WriteLine(" ");
        Console.WriteLine("Camping in a house");
        Console.WriteLine("kill/death ratio, "+ houseCamp.kills + "/"+ houseCamp.deaths);
        Console.WriteLine("Win/lose ratio, "+ houseCamp.victory + "/" + houseCamp.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Playing aggressivly");
        Console.WriteLine("kill/death ratio, "+ Hunting.kills + "/"+ Hunting.deaths);
        Console.WriteLine("Win/lose ratio, "+ Hunting.victory  + "/" + Hunting.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Staying in one area");
        Console.WriteLine("kill/death ratio, "+ areaLooter.kills + "/"+ areaLooter.deaths);
        Console.WriteLine("Win/lose ratio, "+  areaLooter.victory + "/" + areaLooter.deaths);
        Console.WriteLine(" ");
        Console.WriteLine("Climbing the tower, and camping");
        Console.WriteLine("kill/death ratio, "+ climeTowerCamp.kills + "/"+ climeTowerCamp.deaths);
        Console.WriteLine("Win/lose ratio, "+ climeTowerCamp.victory  + "/" + climeTowerCamp.deaths);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("not based on actuall stats");
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