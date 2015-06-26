using System;

class PokerStraight
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());

        int found = 0;
        for (int i = 1; i <= 10; i++)
        {
            int c1 = i;
            int c2 = i + 1;
            int c3 = i + 2;
            int c4 = i + 3;
            int c5 = i + 4;

            int currSum = (c1 * 10) + (c2 * 20) + (c3 * 30) + (c4 * 40) + (c5 * 50);

            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int l = 1; l <= 4; l++)
                    {
                        for (int m = 1; m <= 4; m++)
                        {
                            for (int n = 1; n <= 4; n++)
                            {
                                int currStack = j + k + l + m + n;
                                int total = currSum + currStack;

                                if (total == sum)
                                {
                                    found++;
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(found);
    }
}