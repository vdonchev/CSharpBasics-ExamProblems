using System;
using System.Collections.Generic;

class BitsInverter
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int innerStep = 0;
        int index = 0;
        List<int> output = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                if (index == innerStep)
                {
                    int bit = num >> j & 1;
                    if (bit == 1)
                    {
                        num = num & ~(1 << j);
                    }
                    else
                    {
                        num = num | (1 << j);
                    }

                    innerStep += step;
                }

                index++;
            }

            output.Add(num);
        }

        foreach (var num in output)
        {
            Console.WriteLine(num);
        }
    }
}