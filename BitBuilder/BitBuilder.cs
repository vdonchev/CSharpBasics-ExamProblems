using System;

class BitBuilder
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        string command01 = Console.ReadLine();
        if (command01 == "quit")
        {
            Console.WriteLine((long)num);
            return;
        }
        string command02 = Console.ReadLine();

        while (true)
        {
            int bitPos = int.Parse(command01);

            switch (command02)
            {
                case "flip":
                    num = Flip(num, bitPos);
                    break;
                case "insert":
                    num = Insert(num, bitPos);
                    break;
                case "remove":
                    num = Remove(num, bitPos);
                    break;
                case "skip":
                    break;
            }

            // debug
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(11, '0'));

            command01 = Console.ReadLine();
            if (command01 == "quit")
            {
                Console.WriteLine((long)num);
                return;
            }
            command02 = Console.ReadLine();
        }
    }

    private static long Flip(long nums, int pos)
    {
        long num = nums;
        num ^= 1 << pos;
        return num;
    }

    private static long Insert(long num, int pos)
    {
        long currNum = num;
        long tempNum = 0;

        for (int i = 63; i >= 0; i--)
        {
            long curBit = num >> i & 1;
            tempNum <<= 1;

            if (curBit == 0)
            {
                tempNum &= ~(1);
            }
            else
            {
                tempNum |= 1;
            }

            if (i == pos)
            {
                tempNum <<= 1;
                tempNum |= 1;
            }
        }
        currNum = tempNum;
        return currNum;
    }

    private static long Remove(long num, int pos)
    {
        long currNum = num;
        long tempNum = 0;
        for (int i = 63; i >= 0; i--)
        {
            long curBit = currNum >> i & 1;
            if (i == pos)
            {
                continue;
            }

            tempNum <<= 1;

            if (curBit == 0)
            {
                tempNum &= ~(1);
            }
            else
            {
                tempNum |= 1;
            }

        }
        return tempNum;
    }
}