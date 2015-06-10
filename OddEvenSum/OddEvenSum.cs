using System;

class OddEvenSum
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 1; i <= numbers * 2; i++)
        {
            int currentDigit = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += currentDigit;
            }
            else
            {
                oddSum += currentDigit;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}