using System;
using System.Collections.Generic;

class CatchTheBits
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string bitHolder = string.Empty;
        int index = 0;
        List<int> output = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int bit = 7; bit >= 0; bit--)
            {
                if ((index % step == 1) || (step == 1 && index > 0))
                {
                    bitHolder += num >> bit & 1;
                    if (bitHolder.Length >= 8)
                    {
                        output.Add(Convert.ToInt32(bitHolder, 2));
                        bitHolder = string.Empty;
                    }
                }

                index++;
            }
        }

        if (bitHolder.Length > 0)
        {
            output.Add(Convert.ToInt32(bitHolder.PadRight(8, '0'), 2));
        }

        foreach (var nums in output)
        {
            Console.WriteLine(nums);
        }
    }
}