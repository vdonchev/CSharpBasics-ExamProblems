using System;

class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());

        int step = 61;
        while (step > 0)
        {
            if ((num >> step & 7) == 7 || (num >> step & 7) == 0)
            {
                num ^= (ulong)7 << step;
                step -= 2;
            }
            step--;
        }

        Console.WriteLine(num);
    }
}