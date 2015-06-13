using System;

class BitsAtCrossroads
{
    static void Main()
    {
        // get the board size
        int size = int.Parse(Console.ReadLine());

        // fill the board
        int[] nums = new int[size];
        for (int i = 0; i < size; i++)
        {
            nums[i] = 0;
        }

        int crossroad = 0;

        // get the 1st command
        string[] action = Console.ReadLine().Split();

        // loop through the commands
        while (action[0] != "end")
        {
            int y = int.Parse(action[0]);
            int x = int.Parse(action[1]);

            // set the current crossroad
            nums[y] |= 1 << x;
            crossroad++;

            // print left-top
            bool ok = true;
            int currentY = y - 1;
            int currentX = x + 1;
            while (ok)
            {
                if (currentY >= 0 && currentX <= (size - 1))
                {
                    if ((nums[currentY] >> currentX & 1) == 1)
                    {
                        crossroad++;
                    }
                    nums[currentY] |= 1 << currentX;
                    currentY--;
                    currentX++;
                }
                else
                {
                    ok = false;
                }
            }

            // print top-right
            ok = true;
            currentY = y - 1;
            currentX = x - 1;
            while (ok)
            {
                if (currentY >= 0 && currentX >= 0)
                {
                    if ((nums[currentY] >> currentX & 1) == 1)
                    {
                        crossroad++;
                    }
                    nums[currentY] |= 1 << currentX;
                    currentY--;
                    currentX--;
                }
                else
                {
                    ok = false;
                }
            }

            // print bottom-right
            ok = true;
            currentY = y + 1;
            currentX = x - 1;
            while (ok)
            {
                if (currentY <= (size - 1) && currentX >= 0)
                {
                    if ((nums[currentY] >> currentX & 1) == 1)
                    {
                        crossroad++;
                    }
                    nums[currentY] |= 1 << currentX;
                    currentY++;
                    currentX--;
                }
                else
                {
                    ok = false;
                }
            }

            // print bottom-left
            ok = true;
            currentY = y + 1;
            currentX = x + 1;
            while (ok)
            {
                if (currentY <= (size - 1) && currentX <= (size - 1))
                {
                    if ((nums[currentY] >> currentX & 1) == 1)
                    {
                        crossroad++;
                    }
                    nums[currentY] |= 1 << currentX;
                    currentY++;
                    currentX++;
                }
                else
                {
                    ok = false;
                }
            }

            // debug
            //foreach (var num in nums)
            //{
            //    Console.WriteLine(Convert.ToString(num, 2).PadLeft(size, '0'));
            //}

            // get another command
            action = Console.ReadLine().Split();
        }

        // output
        foreach (var num in nums)
        {
            Console.WriteLine((uint)num);
        }
        Console.WriteLine(crossroad);
    }
}