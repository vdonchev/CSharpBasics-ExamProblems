using System;

class BitRoller
{
    static void Main()
    {
        // inputs
        int num = int.Parse(Console.ReadLine());
        int frozenPos = int.Parse(Console.ReadLine());
        int rotations = int.Parse(Console.ReadLine());

        int temp = 0;
        int frozenBit = num >> frozenPos & 1;

        for (int rotates = 0; rotates < rotations; rotates++)
        {
            for (int i = 0; i < 19; i++)
            {
                // move the frozen bit
                if (i == frozenPos)
                {
                    if (frozenBit == 0)
                    {
                        temp &= ~(1 << frozenPos);
                    }
                    else
                    {
                        temp |= 1 << frozenPos;
                    }
                    continue;
                }

                int currentBit = num >> i & 1; // get the bit valule

                int bitNewPos = GetPosition(i, frozenPos);

                // set the new bit in the temp num
                if (currentBit == 0)
                {
                    temp &= ~(1 << bitNewPos);
                }
                else
                {
                    temp |= 1 << bitNewPos;
                }

            }
            num = temp;
        }

        Console.WriteLine(num);
    }


    private static int GetPosition(int currPos, int freezPos)
    {
        int nextPos = currPos - 1;

        if (currPos == 0)
        {
            nextPos = 18;
        }

        if (nextPos == freezPos && nextPos == 0)
        {
            nextPos = 18;
        }

        if (nextPos == freezPos)
        {
            nextPos--;
        }

        return nextPos;
    }
}