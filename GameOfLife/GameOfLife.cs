using System;

class GameOfLife
{
    static void Main()
    {
        // inputs
        int aliveBits = int.Parse(Console.ReadLine());
        int[] inputNums = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // set predefined bits
        for (int i = 0; i < aliveBits; i++)
        {
            int curNum = int.Parse(Console.ReadLine());
            int curBit = int.Parse(Console.ReadLine());

            inputNums[curNum] |= 1 << curBit;
        }

        // copy the original array
        int[] nums = new int[10];
        Array.Copy(inputNums, nums, 10);

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                int currBitStatus = inputNums[i] >> j & 1;
                int aliveNeighbours = CountNeighbours(inputNums, i, j);

                if (currBitStatus == 0 && aliveNeighbours == 3)
                {
                    nums[i] = nums[i] | 1 << j;
                }

                if (currBitStatus == 1)
                {
                    if (aliveNeighbours < 2)
                    {
                        nums[i] = nums[i] & ~(1 << j);
                    }

                    if (aliveNeighbours > 3)
                    {
                        nums[i] = nums[i] & ~(1 << j);
                    }
                }
            }
        }

        // print the results
        foreach (var nume in nums)
        {
            Console.WriteLine(Convert.ToString(nume, 2).PadLeft(10, '0'));
        }
    }

    private static int CountNeighbours(int[] nums, int num, int bit)
    {
        int alive = 0;

        if (bit + 1 <= 9)
        {
            alive += (IfAlive(nums[num], bit + 1)) ? 1 : 0;
        }

        if (bit - 1 >= 0)
        {
            alive += (IfAlive(nums[num], bit - 1)) ? 1 : 0;
        }

        if (num - 1 >= 0)
        {
            alive += (IfAlive(nums[num - 1], bit)) ? 1 : 0;

            if (bit + 1 <= 9)
            {
                alive += (IfAlive(nums[num - 1], bit + 1)) ? 1 : 0;
            }

            if (bit - 1 >= 0)
            {
                alive += (IfAlive(nums[num - 1], bit - 1)) ? 1 : 0;
            }

        }

        if (num + 1 <= 9)
        {
            alive += (IfAlive(nums[num + 1], bit)) ? 1 : 0;

            if (bit + 1 <= 9)
            {
                alive += (IfAlive(nums[num + 1], bit + 1)) ? 1 : 0;
            }

            if (bit - 1 >= 0)
            {
                alive += (IfAlive(nums[num + 1], bit - 1)) ? 1 : 0;
            }
        }

        return alive;
    }

    private static bool IfAlive(int num, int bit)
    {
        if ((num >> bit & 1) == 1)
        {
            return true;
        }
        return false;
    }
}