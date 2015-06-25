using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int nSum = 0;
        while (num != 0)
        {
            nSum += num % 10;
            num /= 10;
        }
        bool found = false;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    for (int l = 0; l < 6; l++)
                    {
                        for (int m = 0; m < 6; m++)
                        {
                            for (int n = 0; n < 6; n++)
                            {
                                int currProduct = i * j * k * l * m * n;
                                if (currProduct == nSum)
                                {
                                    found = true;
                                    string match = "" + i + j + k + l + m + n;
                                    PrintMorse(match);
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    static void PrintMorse(string match)
    {
        for (int i = 0; i < match.Length; i++)
        {
            switch (match[i])
            {
                case '0':
                    Console.Write("-----|");
                    break;
                case '1':
                    Console.Write(".----|");
                    break;
                case '2':
                    Console.Write("..---|");
                    break;
                case '3':
                    Console.Write("...--|");
                    break;
                case '4':
                    Console.Write("....-|");
                    break;
                case '5':
                    Console.Write(".....|");
                    break;
            }
        }

        Console.WriteLine();
    }
}