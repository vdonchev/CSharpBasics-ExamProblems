using System;

class BookProblem
{
    static void Main()
    { 
        // Inputs
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int readPages = int.Parse(Console.ReadLine());

        // Logic
        int readingDays = 30 - campingDays;
        int readPerMonth = readingDays * readPages;

        if (readPerMonth <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double monthsNeeded = Math.Ceiling((double)bookPages / readPerMonth);
            int years = (int)monthsNeeded / 12;
            double months = (double)monthsNeeded % 12;

            // Output
            Console.WriteLine("{0} years {1} months", (int)years, (int)months);
        }
    }
}