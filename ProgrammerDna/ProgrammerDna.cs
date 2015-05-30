using System;

class ProgrammerDna
{
    static void Main()
    {
        // inputs
        int length = int.Parse(Console.ReadLine());
        char startChar = char.Parse(Console.ReadLine());

        int outter = 7 / 2;
        int inner = 1;

        for (int i = 0; i < length; i++)
        {
            if(inner <= 0 || outter > 3)
            {
                inner+=2;
                outter = 7 / 2;
            }
            Console.Write("{0}", new string('.', outter));

            for (int j = 0; j < inner; j++)
            {
                Console.Write(startChar);
                startChar = dnaGenerator(startChar);
            }

            Console.WriteLine("{0}", new string('.', outter));
            if(i % 7 > 2)
            {
                inner-=2;
                outter++;
            }
            else
            {
                inner+=2;
                outter--;
            }
        }
    }

    private static char dnaGenerator(char a)
    {
        a++;
        if(a > 'G')
        {
            a = 'A';
        }
        return a;
    }
}