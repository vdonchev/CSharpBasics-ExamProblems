using System;

class OddEvenElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        if (input[0] == "")
        {
            // Known issue: split on empty string returns 1 token ""
            input = new string[0];
        }

        if (input.Length <= 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }

        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 0; i < input.Length; i++)
        {
            double currentNum = double.Parse(input[i]);

            if (i % 2 == 0)
            {
                oddSum += currentNum;
                oddMin = Math.Min(currentNum, oddMin);
                oddMax = Math.Max(currentNum, oddMax);
            }
            else
            {
                evenSum += currentNum;
                evenMin = Math.Min(currentNum, evenMin);
                evenMax = Math.Max(currentNum, evenMax);
            }
        }

        if (input.Length == 1)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}",
                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}