using System;

class BitShooter
{
    private static void Main()
    {
        ulong battleField = ulong.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            int center = int.Parse(input[0]);
            int range = int.Parse(input[1]);
            int shootRange = range / 2;

            battleField &= ~(1ul << center);

            // right range
            for (int j = center - 1; j >= (center - shootRange) && j >= 0; j--)
            {
                battleField &= ~(1ul << j);
            }

            // left range
            for (int j = center + 1; j <= (center + shootRange) && j < 64; j++)
            {
                battleField &= ~(1ul << j);
            }

        }

        int rightBits = 0;
        int leftBits = 0;

        for (int j = 0; j < 64; j++)
        {
            if (j < 32)
            {
                rightBits += ((battleField >> j & 1ul) == 1) ? 1 : 0;
            }
            else
            {
                leftBits += ((battleField >> j & 1ul) == 1) ? 1 : 0;       
            }
        }

        Console.WriteLine("left: {0}", leftBits);
        Console.WriteLine("right: {0}", rightBits);
    }
}