using System;

class HouseWithWindow
{
    static void Main()
    {
        // input
        int size = int.Parse(Console.ReadLine());

        int width = (2 * size) - 1;
        int roofHeigth = size - 1;
        int baseHeigth = size;
        int winWidth = size - 3;
        int winHeigth = size / 2;
        int aboveBellowWin = (baseHeigth - winHeigth) / 2;

        char brick = '*';
        char bg = '.';

        int outter = size - 2;
        int inner = 1;
        // print roof
        Console.WriteLine("{0}*{0}", new string(bg, size - 1));
        for (int i = 0; i < roofHeigth; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(bg, outter), new string(bg, inner));
            inner += 2;
            outter--;
        }

        // print the base
        Console.WriteLine("{0}", new string(brick, width));
        for (int i = 0; i < aboveBellowWin; i++)
        {
            Console.WriteLine("*{0}*", new string(bg, width - 2));
        }

        for (int i = 0; i < winHeigth; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string(bg, ((width - 2)-winWidth) / 2), new string(brick, winWidth));
        }

        for (int i = 0; i < aboveBellowWin; i++)
        {
            Console.WriteLine("*{0}*", new string(bg, width - 2));
        }
        Console.WriteLine("{0}", new string(brick, width));
    }
}