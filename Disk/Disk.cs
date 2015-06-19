using System;

class Disk
{
    static void Main()
    {
        int canvas = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int x = 0 - ((canvas - 1) / 2);
        int y = (canvas - 1) / 2;

        for (int i = 0; i < canvas; i++)
        {
            for (int j = 0; j < canvas; j++)
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
                
                x++;
            }

            x = 0 - ((canvas - 1) / 2);
            Console.WriteLine();
            y--;
        }
    }
}