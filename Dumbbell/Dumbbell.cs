using System;

class Dumbbell
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        //int input = 9;
        for (int i = 0; i < input / 2 + 1; i++)
        {
            string dumpbell = "&" + new string('*', (input / 2 + 1 + i) - 2) + "&";
            if (i == 0)
            {
                dumpbell = new string('&', input / 2 + 1 + i);
            }

            string air = new string('.', input / 2 - i);
            string space = new string('.', input);
            if (input / 2 == i)
            {
                space = new string('=', input);
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", air, dumpbell, space);
        }

        for (int i = input / 2 - 1; i >= 0; i--)
        {
            string dumpbell = "&" + new string('*', (input / 2 + 1 + i) - 2) + "&";
            if (i == 0)
            {
                dumpbell = new string('&', input / 2 + 1 + i);
            }
            string air = new string('.', input / 2 - i);
            string space = new string('.', input);
            Console.WriteLine("{0}{1}{2}{1}{0}", air, dumpbell, space);
        }
    }
}