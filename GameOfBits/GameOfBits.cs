using System;

class GameOfBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        uint newNum = 0;

        while (command != "Game Over!")
        {
            for (int i = 31; i >= 0; i--)
            {
                if (command == "Odd" && i % 2 == 0)
                {
                    newNum <<= 1;
                    newNum |= num >> i & 1;
                }
                else if (command == "Even" && i % 2 == 1)
                {
                    newNum <<= 1;
                    newNum |= num >> i & 1;
                }
            }

            num = newNum;
            newNum = 0;
            command = Console.ReadLine();
        }

        int totalBits = 0;
        for (int i = 0; i < 32; i++)
        {
            totalBits += ((num >> i & 1) == 1) ? 1 : 0;
        }

        Console.WriteLine("{0} -> {1}", num, totalBits);
    }
}