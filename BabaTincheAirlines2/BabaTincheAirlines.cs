using System;
using System.Runtime.InteropServices;

class BabaTincheAirlines
{
    static void Main()
    {
        int maxIncome = 12 * 7000 + (int)(12 * 7000 * 0.005);
        maxIncome += 28 * 3500 + (int)(28 * 3500 * 0.005);
        maxIncome += 50 * 1000 + (int)(50 * 1000 * 0.005);

        string[] firstClass = Console.ReadLine().Split();
        string[] secondClass = Console.ReadLine().Split();
        string[] thirdClass = Console.ReadLine().Split();

        // calculate first class
        int fcIncome = (int.Parse(firstClass[0]) - int.Parse(firstClass[1])) * 7000 + (int)(int.Parse(firstClass[2]) * 7000 * 0.005) + (int.Parse(firstClass[1]) * 2100);
        int scIncome = (int.Parse(secondClass[0]) - int.Parse(secondClass[1])) * 3500 + (int)(int.Parse(secondClass[2]) * 3500 * 0.005) + (int.Parse(secondClass[1]) * 1050);
        int tcIncome = (int.Parse(thirdClass[0]) - int.Parse(thirdClass[1])) * 1000 + (int)(int.Parse(thirdClass[2]) * 1000 * 0.005) + (int.Parse(thirdClass[1]) * 300);

        Console.WriteLine();
        int totalIncome = fcIncome + scIncome + tcIncome;
        Console.WriteLine(totalIncome);
        Console.WriteLine(maxIncome - totalIncome);
    }
}