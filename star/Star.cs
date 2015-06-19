using System;

class Star
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = (2 * size) + 1;
        int topMiddle = size / 2;
        int bottom = (size / 2) + 1;

        int inner = 1;
        int outter = size - 1;

        // print top
        for (int row = 0; row < topMiddle; row++)
        {
            if (row == 0)
            {
                Console.WriteLine("{0}*{0}", new string('.', size));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
                inner += 2;
                outter--;
            }
        }

        outter = 1;
        inner = width - 4;

        // print middle
        for (int row = 0; row < topMiddle; row++)
        {
            if (row == 0)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', (width - (size - 1)) / 2), new string('.', size - 1));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
                inner -= 2;
                outter++;
            }
        }

        outter = size / 2;
        inner = (width - size - 3) / 2;
        int subInner = 1;

        // print bottom
        for (int row = 0; row < bottom; row++)
        {
            if (row == 0)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outter), new string('.', inner));
                outter--;
            }
            else if (row == bottom - 1)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', (width - (size - 1)) / 2), new string('.', size - 1));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outter), new string('.', inner), new string('.', subInner));
                subInner += 2;
                outter--;
            }
        }
    }
}