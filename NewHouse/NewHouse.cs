using System;

class NewHouse
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int inner = 1;
        int outter = size / 2;

        for (int i = 0; i < size + ((size / 2) + 1); i++)
        {
            if (i > size / 2)
            {
                Console.WriteLine("|{0}|", new string('*', size - 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', outter), new string('*', inner));
                inner += 2;
                outter--;
            }
        }
    }
}