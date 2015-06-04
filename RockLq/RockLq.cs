using System;

public class RockLq
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int outter = input - 2;
        int middle = 1;
        int inner = input + 2;

        Console.WriteLine("{0}{1}{0}", new string('.', input), new string('*', input));

        for (int i = 0; i < input / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
            outter -= 2;
            inner += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', input - 2), new string('.', input));

        outter = input - 4;
        for (int i = 1; i < input / 2; i++)
        {
            Console.WriteLine("*{0}*{2}*{1}*{2}*{0}*", new string('.', outter), new string('.', input), new string('.', middle));
            middle += 2;
            outter -= 2;
        }

        outter = input - 1;
        inner = input;
        char innerChar = '.';

        for (int i = 0; i < input; i++)
        {
            innerChar = (i == input - 1) ? '*' : innerChar;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string(innerChar, inner));
            inner += 2;
            outter--;
        }
    }
}