using System;
using System.Runtime.DesignerServices;

class BookOrders
{
    static void Main()
    {
        long orders = long.Parse(Console.ReadLine());
        double totalSum = 0;
        long totalBooks = 0;

        for (int i = 0; i < orders; i++)
        {
            long packs = long.Parse(Console.ReadLine());
            long books = long.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double discount = 0;
            if (packs >= 10 && packs < 110)
            {
                discount = ((packs / 10) + 4) / 100D;
            }
            else if (packs >= 110)
            {
                discount = 15 / 100D;
            }

            price -= price * discount;

            totalBooks += packs * books;
            totalSum += packs * books * price;
        }

        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:F2}", totalSum);
    }
}