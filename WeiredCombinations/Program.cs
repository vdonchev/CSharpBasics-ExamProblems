using System;

class Program
{
    static void Main()
    {
        string phrase = Console.ReadLine();
        int pos = int.Parse(Console.ReadLine());

        int combos = 0;

        bool found = false;

        for (int i = 0; i < 5; i++)
        {
            char one = phrase[i];
            for (int j = 0; j < 5; j++)
            {
                char two = phrase[j];
                for (int k = 0; k < 5; k++)
                {
                    char three = phrase[k];
                    for (int l = 0; l < 5; l++)
                    {
                        char four = phrase[l];
                        for (int m = 0; m < 5; m++)
                        {
                            char five = phrase[m];
                            string combo = "" + one + two + three + four + five;
                            if (combos == pos)
                            {
                                Console.WriteLine(combo);
                                found = true;
                            }

                            combos++;
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
}