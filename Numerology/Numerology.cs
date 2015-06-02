using System;

class Numerology
{
    static void Main()
    {
        // inputs
        string[] input = Console.ReadLine().Split('.', ' ');

        int day = int.Parse(input[0]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        string word = input[3];

        long dateSum = day * month * year;
        if (month % 2 != 0)
        {
            dateSum *= dateSum;
        }

        long letterValue = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(word[i]))
            {
                if (char.IsUpper(word[i]))
                {
                    letterValue += (Char.ToLower(word[i]) - 96) * 2;
                }
                else
                {
                    letterValue += Char.ToLower(word[i]) - 96;
                }
            }
            else
            {
                letterValue += (int)Char.GetNumericValue(word[i]);
            }
        }
        long totalSum = dateSum + letterValue;

        
        while (totalSum > 13)
        {
            string allDigits = Convert.ToString(totalSum);
            int newSum = 0;
            for (int i = 0; i < allDigits.Length; i++)
            {
                newSum += (int)Char.GetNumericValue(allDigits[i]);
            }
            totalSum = newSum;
        }
        Console.WriteLine(totalSum);
    }
}