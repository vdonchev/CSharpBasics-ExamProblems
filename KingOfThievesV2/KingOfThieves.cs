using System;

class KingOfThieves
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        char innerSymbol = char.Parse(Console.ReadLine());

        int innerCount = 1;
        int outterCount = rows / 2;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', outterCount), new string(innerSymbol, innerCount));
            if(i < rows / 2 )
            {
                innerCount += 2;
                outterCount--;
            }
            else
            {
                innerCount -= 2;
                outterCount++;
            }
        }
    }
}