using System;

class Sunglasses
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = height * 2;

        for (int i = 0; i < height; i++)
        {
            if (i == 0 || i == height - 1)
            {
                TopBottom(height);
            }
            else
            {
                Middle(height, i);
            }
        }
    }

    private static void TopBottom(int n)
    {
        string asterix = new string('*', n * 2);
        string bridge = new string(' ', n);
        Console.WriteLine("{0}{1}{0}", asterix, bridge);
    }

    private static void Middle(int n, int i)
    {
        string asterix = new string('*', 1);
        string fill = new string('/', n * 2 - 2);
        string bridge = new string(' ', n);
        if (i == n / 2)
        {
            bridge = new string('|', n);
        }

        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, fill, bridge);
    }
}