using System;

class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int monthlyIncome = ((30 - partyDays) * 2) - (partyDays * 5);

        if (monthlyIncome <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double totalMonths = (double)tankPrice / monthlyIncome;
            int result = (int)Math.Ceiling(totalMonths);
            int years = result / 12;
            int months = result % 12;
            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}