using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", string.Empty);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        int oddIndex = 1;
        int evenIndex = 1;

        long oddSum = 0;
        long evenSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (oddIndex % oddJump == 0)
                {
                    oddSum *= input[i];
                }
                else
                {
                    oddSum += input[i];
                }

                oddIndex++;
            }
            else
            {
                if (evenIndex % evenJump == 0)
                {
                    evenSum *= input[i];
                }
                else
                {
                    evenSum += input[i];
                }

                evenIndex++;
            }
        }

        Console.WriteLine("Odd: {0}", Convert.ToString(oddSum, 16).ToUpper());
        Console.WriteLine("Even: {0}", Convert.ToString(evenSum, 16).ToUpper());
    }
}