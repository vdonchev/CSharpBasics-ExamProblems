using System;

class MagicWand
{
    static void Main()
    {
        // ipnput
        int size = int.Parse(Console.ReadLine());

        int width = (3 * size) + 2;
        int topHeigth = (size / 2) + 1;
        int middleBottomHeigth = (size / 2);
        int handleHeigth = size;

        int outter = (width - 3) / 2;
        int inner = 1;

        // print top
        Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));
        for (int i = 0; i < topHeigth; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
            inner += 2;
            outter--;
        }

        // print middle
        Console.WriteLine("{0}*{1}*{0}", new string('*', outter), new string('.', inner));
        outter = 1;
        inner = width - 4;
        for (int i = 0; i < middleBottomHeigth; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
            outter++;
            inner -= 2;
        }

        // print bottom
        outter -= 2;
        inner = size;
        int subInner = size / 2;
        int subInner2 = 0;

        for (int i = 0; i < middleBottomHeigth; i++)
        {
            Console.WriteLine("{0}*{2}*{3}*{1}*{3}*{2}*{0}", 
                new string('.', outter), 
                new string('.', inner), 
                new string('.', subInner),
                new string('.', subInner2));
            outter--;
            subInner2++;
        }
        Console.WriteLine("{2}{0}*{1}*{0}{2}", new string('.', subInner2), new string('.', inner), new string('*', (size / 2) + 1));

        // print handle
        outter = (width - (size + 2)) / 2;
        for (int i = 0; i < handleHeigth; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
        }
        Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('*', inner));
    }
}