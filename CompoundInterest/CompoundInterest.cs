using System;

class CompoundInterest
{
    static void Main()
    {
        // inputs
        decimal tvPrice = decimal.Parse(Console.ReadLine());
        int bankTerm = int.Parse(Console.ReadLine());
        decimal bankInt = decimal.Parse(Console.ReadLine());
        decimal friendInt = decimal.Parse(Console.ReadLine());

        decimal bankLoan = calculateLoan(tvPrice, bankInt, bankTerm);
        decimal friendLoan = calculateLoan(tvPrice, friendInt, 1);
        string cheapLoan = (bankLoan < friendLoan) ? "Bank" : "Friend";
        decimal loanSize = Math.Min(bankLoan, friendLoan);
        Console.WriteLine("{0:F2} {1}", loanSize, cheapLoan);
    }

    private static decimal calculateLoan(decimal tvPrice, decimal interest, int term)
    {
        decimal readyInt = (1 + interest);
        decimal outputInt = 1;
        for (int i = 0; i < term; i++)
        {
            outputInt *= readyInt;
        }
        return tvPrice * outputInt;
    }
}