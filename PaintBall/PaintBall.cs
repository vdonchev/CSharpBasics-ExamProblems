using System;

class PaintBall
{
    static void Main()
    {
        int[] canvas = new int[10];
        for (int i = 0; i < 10; i++)
        {
            canvas[i] = 1023;
        }

        string[] command = Console.ReadLine().Split(' ');

        while (command[0] != "End")
        {

            command = Console.ReadLine().Split(' ');
        }
    }
}