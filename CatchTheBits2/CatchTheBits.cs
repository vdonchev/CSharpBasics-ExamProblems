using System;

class CatchTheBits
{
    static void Main()
    {
        Console.WriteLine(1 % 3);

        int count = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        string output = string.Empty;

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 7; j>= 0; j--)
            {
                if (index % step == 1 || (step == 1 && index > 0))
                {
                    if (output.Length < 9)
                    {
                        output += num >> j & 1;
                    }
                    else
                    {
                        // to be continued
                    }
                }
                index++;
            }
        }
    }
}