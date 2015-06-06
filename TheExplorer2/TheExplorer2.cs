using System;

class TheExplorer2
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('-', size / 2));

        int inner = 1;
        int outter = (size - 3) / 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outter), new string('-', inner));
            outter--;
            inner += 2;
        }

        inner = size - 4;
        outter = 1;

        for (int i = 1; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outter), new string('-', inner));
            outter++;
            inner -= 2;
        }

        Console.WriteLine("{0}*{0}", new string('-', size / 2));
    }
}