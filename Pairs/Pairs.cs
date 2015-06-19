using System;

class Pairs
{
    static void Main()
    {
        // input
        string[] input = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(input, s => int.Parse(s));
        int maxDiff = 0;
        int Prevsum = nums[0] + nums[1];

        for (int i = 2; i < nums.Length; i += 2)
        {
            int currentSum = nums[i] + nums[i + 1];
            if (currentSum != Prevsum)
            {
                maxDiff = (Math.Abs(currentSum - Prevsum) > maxDiff) ? Math.Abs(currentSum - Prevsum) : maxDiff;
                Prevsum = currentSum;
            }
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", Prevsum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}