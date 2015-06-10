using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int hollydays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int normalWeekends = 48 - hometownWeekends;

        double totalPlays = hometownWeekends + (normalWeekends * 0.75D) + ((hollydays / 3D) * 2D);
        totalPlays += (yearType == "leap") ? totalPlays * 0.15D : 0;

        Console.WriteLine((int)totalPlays);
    }
}