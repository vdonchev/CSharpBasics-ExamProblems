using System;

class WineGlass
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int top = size / 2;
        int stem = (size >= 12) ? (size / 2) - 2 : (size / 2) - 1;
        int bottom = size - top - stem;

        int inner = size - 2;
        int outter = 0;

        // print top
        for (int i = 0; i < top; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('.', outter), new string('*', inner));
            inner -= 2;
            outter++;
        }

        // print stem
        for (int i = 0; i < stem; i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', (size / 2) - 1));
        }

        // print bottom
        for (int i = 0; i < bottom; i++)
        {
            Console.WriteLine(new string('-', size));
        }
    }
}