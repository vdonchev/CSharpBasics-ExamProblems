using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicNum = int.Parse(Console.ReadLine());
        int nums = 0;
        for (int a = 0; a < 10; a++)
        {
            nums += CountNumbers(a + a + a + a, a.ToString() + a + a + a, magicNum);
            for (int b = 0; b < 10; b++)
            {
                if (a != b)
                {
                    nums += CountNumbers(a + b + b + b, a.ToString() + b + b + b, magicNum);
                    nums += CountNumbers(a + a + a + b, a.ToString() + a + a + b, magicNum);
                    nums += CountNumbers(a + a + b + b, a.ToString() + a + b + b, magicNum);
                    nums += CountNumbers(a + b + a + b, a.ToString() + b + a + b, magicNum);
                    nums += CountNumbers(a + b + b + a, a.ToString() + b + b + b, magicNum);
                }
            }
        }

        Console.WriteLine(nums);
    }

    static int CountNumbers(int sum, string nums, int magicNum)
    {
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int foundNums = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            char letter1 = letters[i];
            for (int j = 0; j < letters.Length; j++)
            {
                char letter2 = letters[j];

                int lettersSum = ((letter1 + letter2) - 128) * 10;

                if (lettersSum + sum + 40 == magicNum)
                {
                    foundNums++;
                }
            }
        }
        return foundNums;
    }
}