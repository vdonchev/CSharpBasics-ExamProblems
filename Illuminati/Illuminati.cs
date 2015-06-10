using System;

class Illuminati
{
    static void Main()
    {
        string movieLine = Console.ReadLine().ToUpper();
        int vowelsCount = 0;
        int vowelsSum = 0;

        for (int i = 0; i < movieLine.Length; i++)
        {
            if (IsVowel(movieLine[i]))
            {
                vowelsSum += movieLine[i];
                vowelsCount++;
            }
        }

        Console.WriteLine("{0}\n{1}", vowelsCount, vowelsSum);
    }

    private static bool IsVowel(char letter)
    {
        bool vowel = "AEIOU".IndexOf(letter) >= 0;
        return vowel;
    }
}