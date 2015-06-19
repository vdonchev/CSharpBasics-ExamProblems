using System;

class WinningNumbers
{
    static void Main()
    {
        // input 
        string phrase = Console.ReadLine().ToLower();
        int found = 0;

        int phraseSum = 0;
        for (int i = 0; i < phrase.Length; i++)
        {
            phraseSum += phrase[i] - 96;
        }

        for (int i = 0; i < 10; i++)
        {
            int a = i;
            for (int j = 0; j < 10; j++)
            {
                int b = j;
                for (int k = 0; k < 10; k++)
                {
                    int c = k;
                    if (a * b * c == phraseSum)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            int d = l;
                            for (int m = 0; m < 10; m++)
                            {
                                int e = m;
                                for (int n = 0; n < 10; n++)
                                {
                                    int f = n;
                                    if (d * e * f == phraseSum)
                                    {
                                        found++;
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c, d, e, f);
                                    }
                                }
                            }
                        }   
                    }
                }
            }
        }
        if (found == 0)
        {
            Console.WriteLine("No");
        }
    }
}