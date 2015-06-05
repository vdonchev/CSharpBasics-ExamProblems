using System;

namespace PandaFlag
{
    class PandaFlag
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int outter = 0;
            int inner = size - 2;
            char border = 'A';

            for (int i = 0; i < size / 2; i++)
            {
                Console.Write("{0}{1}", new string('~', outter), border);
                border = Gen(border);
                Console.WriteLine("{0}{1}{2}", new string('#', inner), border, new string('~', outter));
                border = Gen(border);
                inner -= 2;
                outter++;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', size / 2), border);
            border = Gen(border);

            inner += 2;
            outter--;

            for (int i = 0; i < size / 2; i++)
            {
                Console.Write("{0}{1}", new string('~', outter), border);
                border = Gen(border);
                Console.WriteLine("{0}{1}{2}", new string('#', inner), border, new string('~', outter));
                border = Gen(border);
                inner += 2;
                outter--;
            }
        }

        private static char Gen(char n)
        {
            n++;
            return (n > 'Z') ? 'A' : n;
        }
    }
}