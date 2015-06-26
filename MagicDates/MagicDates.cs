using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicSum = int.Parse(Console.ReadLine());
        bool found = false;

        for (DateTime d = new DateTime(startYear, 01, 01); d <= new DateTime(endYear, 12, 31); d = d.AddDays(1))
        {
            int[] currYear = new int[8];

            currYear[0] = (d.Day / 10) % 10;
            currYear[1] = (d.Day / 1) % 10;
            currYear[2] = (d.Month / 10) % 10;
            currYear[3] = (d.Month / 1) % 10;
            currYear[4] = (d.Year / 1000) % 10;
            currYear[5] = (d.Year / 100) % 10;
            currYear[6] = (d.Year / 10) % 10;
            currYear[7] = (d.Year / 1) % 10;

            int sum = 0;
            for (int i = 0; i < currYear.Length - 1; i++)
            {
                for (int j = i + 1; j < currYear.Length; j++)
                {
                    sum += currYear[i] * currYear[j];
                }
            }

            if (sum == magicSum)
            {
                found = true;
                Console.WriteLine("{0:00}-{1:00}-{2}", d.Day, d.Month, d.Year);
            }

        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}