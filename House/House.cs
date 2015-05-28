using System;

class House
{
    static void Main()
    {
        // inputs
        int input = int.Parse(Console.ReadLine());

        //roof
        Console.WriteLine("{0}*{0}", new string('.', input / 2));

        int inside = 1;
        int outside = input / 2 - 1;
        for (int i = 0; i < input / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outside), new string('.', inside));
            outside--;
            inside += 2;
        }
        Console.WriteLine(new string('*', input));

        // walls
        outside = input / 4;
        inside = input - 2 - (outside * 2);
        char bg = '.';
        for (int i = 0; i < input / 2; i++)
        {
            if (i == input / 2 - 1) 
            {
                bg = '*';
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', outside), new string(bg, inside));
        }
        Console.ReadLine();
    }
}