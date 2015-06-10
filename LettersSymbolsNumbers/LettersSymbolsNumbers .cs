using System;

class LettersSymbolsNumbers
{
    static void Main()
    {
        int numStrings = int.Parse(Console.ReadLine());
        long sumLetters = 0;
        long sumDigits = 0;
        long sumSymbols = 0;

        for (int i = 0; i < numStrings; i++)
        {
            string theInput = Console.ReadLine().ToUpper().Replace(" ", string.Empty);

            for (int j = 0; j < theInput.Length; j++)
            {
                char current = theInput[j];

                if (current >= 'A' && current <= 'Z')
                {
                    sumLetters += (theInput[j] - 64) * 10;
                }
                else if (current >= '0' && current <= '9')
                {
                    sumDigits += (theInput[j] - 48) * 20;
                }
                else if (current == '\n' || current == '\r' || current == '\t')
                {
                    continue;
                }
                else
                {
                    sumSymbols += 200;
                }
            }
        }

        Console.WriteLine("{0}\n{1}\n{2}", sumLetters, sumDigits, sumSymbols);
    }
}