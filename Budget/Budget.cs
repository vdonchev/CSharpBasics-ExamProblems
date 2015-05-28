using System;

class Budget
{
    static void Main()
    {
        // inputs
        int kirosMoney = int.Parse(Console.ReadLine());
        int daysOut = int.Parse(Console.ReadLine());
        int homeWeekends = int.Parse(Console.ReadLine());

        // logic
        int normalWeekends = (4 - homeWeekends) * 40;
        int normalDays = (22 - daysOut) * 10;
        int goOutDays = (int)(0.03 * kirosMoney) + 10;
        int spentMoney = 150 + normalWeekends + normalDays + (daysOut * goOutDays);

        // output
        if (spentMoney == kirosMoney) 
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (spentMoney > kirosMoney)
        {
            Console.WriteLine("No, not enough {0}.", spentMoney - kirosMoney);
        }
        else
        {
            Console.WriteLine("Yes, leftover {0}.", kirosMoney - spentMoney);
        }
    }
}