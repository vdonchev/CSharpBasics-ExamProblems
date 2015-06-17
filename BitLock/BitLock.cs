using System;

class BitLock
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[8];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        string[] command = Console.ReadLine().Split(' ');

        while (command[0] != "end")
        {
            if (command[0] == "check")
            {
                int foundBits = 0;
                for (int i = 0; i < 8; i++)
                {
                    int bit = nums[i] >> int.Parse(command[1]) & 1;
                    if (bit == 1)
                    {
                        foundBits++;
                    }
                }

                Console.WriteLine(foundBits);
            }
            else
            {
                int row = int.Parse(command[0]);
                string direction = command[1];
                int rotations = int.Parse(command[2]);

                for (int i = 0; i < rotations; i++)
                {
                    if (direction == "right")
                    {
                        int rightBit = nums[row] & 1;
                        nums[row] >>= 1;
                        if (rightBit == 1)
                        {
                            nums[row] |= 1 << 11;
                        }
                        else
                        {
                            nums[row] &= ~(1 << 11);
                        }
                    }
                    else
                    {
                        int leftBit = nums[row] >> 11 & 1;

                        nums[row] &= ~(1 << 11);
                        nums[row] <<= 1;
                        if (leftBit == 1)
                        {
                            nums[row] |= 1;
                        }
                        else
                        {
                            nums[row] &= ~1;
                        }
                    }
                }
            }

            command = Console.ReadLine().Split(' ');
        }

        foreach (var num in nums)
        {
            Console.Write("{0} ", num);
        }
    }
}