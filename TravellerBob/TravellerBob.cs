using System;

class TravellerBob
{
    static void Main()
    {
        // inputs
        string yearType = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        double regularMonths = 12D - contractMonths - familyMonths;

        // logic
        double contractTravels = contractMonths * 12D;
        double familyTravels = familyMonths * 4D;
        double regularTravels = regularMonths * (12D * 60D / 100D);
        double totalTravels = contractTravels + familyTravels + regularTravels;

        if (yearType == "leap")
        {
            totalTravels += totalTravels * 0.05;
        }

        // output
        Console.WriteLine((int)totalTravels);
    }
}