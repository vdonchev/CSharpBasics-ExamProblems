using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesNeeded = long.Parse(Console.ReadLine());

        long legs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tablesMade = Math.Min((legs / 4), tableTops);

        if (tablesMade > tablesNeeded)
        {
            long topsLeft = tableTops - tablesNeeded;
            long legsLeft = legs - (tablesNeeded * 4);
            Console.WriteLine("more: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tablesMade < tablesNeeded)
        {
            long topsNeeded = tablesNeeded >= tableTops ? tablesNeeded - tableTops : 0;
            long legsNeeded = tablesNeeded * 4 >= legs ? tablesNeeded * 4 - legs : 0;
            Console.WriteLine("less: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}