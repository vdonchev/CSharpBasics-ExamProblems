using System;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        ulong num1 = ulong.Parse(Console.ReadLine());
        ulong num2 = ulong.Parse(Console.ReadLine());
        ulong num3 = ulong.Parse(Console.ReadLine());

        List<ulong> tri = new List<ulong>();
        tri.Add(num1);
        tri.Add(num2);
        tri.Add(num3);

        ulong current = 0;
        while (current <= 1000000)
        {
            current = num1 + num2 + num3;
            tri.Add(current);
            num1 = num2;
            num2 = num3;
            num3 = current;
        }

        ulong start = ulong.Parse(Console.ReadLine());
        ulong step = ulong.Parse(Console.ReadLine());

        for (ulong i = 1; start <= 1000000; i++)
        {
            for (ulong j = 0; j < 2; j++)
            {
                foreach (var num in tri)
                {
                    if (num == start && start <= 1000000)
                    {
                        Console.WriteLine(num);
                        return;
                    }
                }
                start += i * step;
            }
        }

        Console.WriteLine("No");
    }
}