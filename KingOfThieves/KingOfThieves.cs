using System;

class KingOfThieves
{
    static void Main()
    {
        // inputs
        int size = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());

        // top part
        for (int i = 0; i < size / 2 + 1; i++)
        {
            int gemStr = 1 + (i * 2);
            int spaceStr = (size - gemStr) / 2;
            string gem = new string(type, gemStr);
            string space = new string('-', spaceStr);
            Console.WriteLine("{0}{1}{0}", space, gem);
        }
        // bottom part
        for (int i = size / 2; i > 0; i--)
        {
            int gemStr = (i * 2) - 1;
            int spaceStr = (size - gemStr) / 2;
            string gem = new string(type, gemStr);
            string space = new string('-', spaceStr);
            Console.WriteLine("{0}{1}{0}", space, gem);
        }
    }
}