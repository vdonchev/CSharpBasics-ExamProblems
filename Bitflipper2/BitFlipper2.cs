using System;

class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());

        for (int i = 62; i >= 1; i--)
        {
            ulong currBit = num >> i & 1;
            ulong leftBit = num >> i - 1 & 1;
            ulong rightBit = num >> i + 1 & 1;

            if (currBit == leftBit && leftBit == rightBit)
            {
                num ^= 1ul << i;
                num ^= 1ul << i + 1;
                num ^= 1ul << i - 1;

                i -= 2;
                if (i < 0)
                {
                    break;
                }
            }
        }

        Console.WriteLine(num);
    }
}