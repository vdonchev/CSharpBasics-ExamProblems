using System;

class DoubleDowns
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] nums = new int[count];

        int rightDiagonal = 0;
        int leftDiagonal = 0;
        int vertical = 0;

        for (int i = 0; i < count; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int rows = 0; rows < nums.Length; rows++)
        {
            int currentNum = nums[rows];
            if (rows < (nums.Length - 1))
            {
                int nextNum = nums[rows + 1];

                for (int bit = 0; bit < 32; bit++)
                {
                    if ((currentNum >> bit & 1) == 1 && (nextNum >> bit & 1) == 1)
                    {
                        vertical++;
                    }
                    
                    if ((currentNum >> bit & 1) == 1 && (nextNum >> (bit + 1) & 1) == 1)
                    {
                        leftDiagonal++;
                    }
                    
                    if ((currentNum >> bit & 1) == 1 && (nextNum >> (bit - 1) & 1) == 1)
                    {
                        rightDiagonal++;
                    }
                }
            }
        }

        Console.WriteLine("{0}{3}{1}{3}{2}", rightDiagonal, leftDiagonal, vertical, Environment.NewLine);
    }
}