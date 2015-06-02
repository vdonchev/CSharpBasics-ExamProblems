using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        int index = 0;

        for (int i = 0; i <= y; i++)
        {
            if(i == y) {
                index += x + 1;
            }
            else
            {
                index += 3;
            }
        }
        Console.WriteLine((long)Math.Pow(value + index - 1, index));
    }
}