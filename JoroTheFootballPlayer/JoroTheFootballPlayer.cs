using System;

class JoroTheFootballPlayer
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int hollyday = int.Parse(Console.ReadLine());
        int homeTown = int.Parse(Console.ReadLine());

        int allWeeks = 52 - homeTown;
        double totalPlays = ((allWeeks * 2d) / 3d) + (hollyday / 2d) + homeTown;
        totalPlays = (year != "f") ? totalPlays + 3 : totalPlays;

        Console.WriteLine((int)totalPlays);
    }
}