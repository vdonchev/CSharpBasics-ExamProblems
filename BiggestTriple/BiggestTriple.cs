using System;

class BiggestTriple
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int biggestSum = Int32.MinValue;
        int count = 0;
        string winningTripple = string.Empty;

        string currentTriple = string.Empty;
        int currentSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += int.Parse(numbers[i]);
            currentTriple += numbers[i] + ' ';
            count++;
            if (count >= 3 || i == numbers.Length - 1)
            {
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    winningTripple = currentTriple;
                }

                currentSum = 0;
                currentTriple = string.Empty;
                count = 0;
            }

        }
        Console.WriteLine(winningTripple);
    }
}