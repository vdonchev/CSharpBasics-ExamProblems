using System;
using System.Collections.Generic;

class BitsKiller
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int byteOut = 0;
        int numOfBits = 0;
        List<int> output = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                if ((index % step != 1) || (step == 1 && index == 0))
                {
                    byteOut = (byteOut << 1) | (num >> j & 1);

                    numOfBits++;

                    if (numOfBits == 8)
                    {
                        output.Add(byteOut);
                        byteOut = 0;
                        numOfBits = 0;
                    }
                }

                index++;
            }
        }

        if (numOfBits > 0)
        {
            output.Add(byteOut <<= 8 - numOfBits);
        }

        foreach (var num in output)
        {
            Console.WriteLine(num);
        }
    }
}