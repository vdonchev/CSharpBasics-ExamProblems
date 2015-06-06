using System;

class Cinema
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        double ticketPrice = 0D;

        switch (projectionType)
        {
            case "Premiere":
                ticketPrice = 12D;
                break;
            case "Discount":
                ticketPrice = 5D;
                break;
            default:
                ticketPrice = 7.5D;
                break;
        }

        double total = rows * cols * ticketPrice;
        Console.WriteLine("{0:F2} leva", total);
    }
}