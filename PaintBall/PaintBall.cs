using System;

class PaintBall
{
    static void Main()
    {
        // prepare the "white" matrix
        int[] matrix = new int[10];
        for (int i = 0; i < 10; i++)
        {
            matrix[i] = 1023;
        }

        int shots = 0;
        string[] command = Console.ReadLine().Split();
        while (command[0] != "End")
        {
            int y = int.Parse(command[0]);
            int x = int.Parse(command[1]);
            int radius = int.Parse(command[2]);

            // get shoot borders
            int top = (y - radius < 0) ? 0 : y - radius;
            int bottom = (y + radius > 9) ? 9 : y + radius;
            int right = (x - radius < 0) ? 0 : x - radius;
            int left = (x + radius > 9) ? 9 : x + radius;

            // shoot
            for (int num = top; num <= bottom; num++)
            {
                for (int bit = right; bit <= left; bit++)
                {
                    if (shots % 2 == 0)
                    {
                        matrix[num] &= ~(1 << bit);
                    }
                    else
                    {
                        matrix[num] |= 1 << bit;
                    }
                }
            }

            // debug
            //for (int num = 0; num < 10; num++)
            //{
            //    Console.WriteLine(Convert.ToString(matrix[num], 2).PadLeft(10, '0'));
            //}
            shots++;
            command = Console.ReadLine().Split();
        }

        // get the sum
        int sum = 0;
        for (int num = 0; num < 10; num++)
        {
            sum += matrix[num];
        }

        Console.WriteLine(sum);
    }
}