using System;

class CheatSheet
{
    static void Main()
    {
        long rows = long.Parse(Console.ReadLine());
        long cols = long.Parse(Console.ReadLine());
        long h = long.Parse(Console.ReadLine());
        long v = long.Parse(Console.ReadLine());

        for (long i = 0; i < rows; i++)
        {
            for (int num = 0; num < cols; num++)
            {
                string space = " ";
                if (num == cols)
                {
                    space = "";
                }
                long output = (h + i) * (v + num);
                Console.Write("{0}{1}", output, space);
            }
            Console.WriteLine();
        }
    }
}