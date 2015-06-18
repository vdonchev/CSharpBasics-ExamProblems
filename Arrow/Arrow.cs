using System;

class Arrow
{
    static void Main()
    {
        // input
        int width = int.Parse(Console.ReadLine());
        int heigth = width - 2;
        char arrow = '#';
        char bg = '.';

        // print first line
        Console.WriteLine("{0}{1}{0}", new string(bg, width / 2), new string(arrow, width));

        // print tail
        for (int i = 0; i < heigth; i++)
        {
            Console.WriteLine("{0}{2}{1}{2}{0}", new string(bg, width / 2), new string(bg, width - 2), arrow);
        }

        // print top
        Console.WriteLine("{0}{1}{0}", new string(arrow, (width / 2) + 1), new string(bg, width - 2));

        int outter = 1;
        int inner = (width * 2) - 5;

        for (int i = 0; i < heigth; i++)
        {
            Console.WriteLine("{0}{2}{1}{2}{0}", new string(bg, outter), new string(bg, inner), arrow);
            outter++;
            inner -= 2;
        }

        Console.WriteLine("{0}{1}{0}", new string(bg, width - 1), arrow);
    }
}