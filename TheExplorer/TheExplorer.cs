using System;

class TheExplorer
{
    static void Main()
    {
        //input
        int length = int.Parse(Console.ReadLine());

        int inner = 1;
        int outter = length / 2;

        //print
        for (int i = 0; i < length; i++)
        {
            string innerPart;
            if (i == 0 || i == length - 1)
            {
                innerPart = new string('*', inner);
            }
            else
            {
                innerPart = "*" + new string('-', inner - 2) + "*";
            }


            Console.WriteLine("{0}{1}{0}", new string('-', outter), innerPart);

            if (i < length / 2)
            {
                inner += 2;
                outter--;
            }
            else
            {
                inner -= 2;
                outter++;
            }
        }
    }
}