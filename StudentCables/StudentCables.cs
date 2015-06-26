using System;

class StudentCables
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int total = 0;
        int cables = 0;

        for (int i = 0; i < num; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measures = Console.ReadLine();

            if (measures == "centimeters" && length < 20)
            {
                continue;
            }

            if (measures == "meters")
            {
                total += length * 100;
            }
            else
            {
                total += length;
            }
            cables++;
        }

        total -= (cables - 1) * 3;

        Console.WriteLine(total / 504);
        Console.WriteLine(total % 504);
    }
}