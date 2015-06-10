using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string[] timeRange = Console.ReadLine().Split(':');
        int hour = int.Parse(timeRange[0]);
        double consumation = 0D;

        if (hour < 9)
        {
            consumation = (1D * 100.53D) + (8D * 125.90D);
        }
        else if (hour > 13 && hour < 19)
        {
            consumation = (2D * 100.53D) + (2D * 125.90D); 
        }
        else if (hour > 18 && hour < 24)
        {
            consumation = (7D * 100.53D) + (6D * 125.90D);
        }
        else
        {
            consumation = 0D;
        }

        double totalConsumation = floors * flats * consumation;
        Console.WriteLine("{0} Watts", (int)totalConsumation);
    }
}