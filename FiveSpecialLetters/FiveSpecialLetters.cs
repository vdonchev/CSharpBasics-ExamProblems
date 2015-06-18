using System;
using System.Linq;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());
        int match = 0;

        string[] letters = { "a", "b", "c", "d", "e" };

        string word = String.Empty;
        for (int i = 0; i < 5; i++)
        {
            string first = letters[i];
            for (int j = 0; j < 5; j++)
            {
                string second = letters[j];
                for (int k = 0; k < 5; k++)
                {
                    string third = letters[k];
                    for (int l = 0; l < 5; l++)
                    {
                        string fourth = letters[l];
                        for (int m = 0; m < 5; m++)
                        {
                            string fifth = letters[m];
                            word = first + second + third + fourth + fifth;
                            int wordWeigth = CalcWord(word);

                            if (wordWeigth >= start && wordWeigth <= stop)
                            {
                                Console.Write(word + " ");
                                match++;
                            }
                        }
                    }
                }
            }
        }

        if (match == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
    }

    private static int CalcWord(string word)
    {
        string clean = new string(word.ToCharArray().Distinct().ToArray());
        int weigth = 0;
        int index = 1;
        for (int i = 0; i < clean.Length; i++)
        {
            weigth += index * CalcLetters(clean[i]);
            index++;
        }

        return weigth;
    }

    private static int CalcLetters(char letter)
    {
        int letterWeigth = 0;
        switch (letter)
        {
            case 'a':
                letterWeigth = 5;
                break;
            case 'b':
                letterWeigth = -12;
                break;
            case 'c':
                letterWeigth = 47;
                break;
            case 'd':
                letterWeigth = 7;
                break;
            case 'e':
                letterWeigth = -32;
                break;
        }
        return letterWeigth;
    }
}