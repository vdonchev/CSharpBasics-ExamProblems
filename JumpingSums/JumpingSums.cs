using System;

class JumpingSums
{
    static void Main()
    {
        // inputs
        string[] input = Console.ReadLine().Split();
        int jumps = int.Parse(Console.ReadLine());

        // convert to int array
        int[] nums = Array.ConvertAll(input, s => int.Parse(s));
        int numCount = nums.Length;
        int biggestSum = 0;

        // loop through every single num
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = nums[i];
            int index = i;

            // do the jumps
            for (int j = 0; j < jumps; j++)
            {
                index = (index + nums[index]) % numCount;
                sum += nums[index];
            }
            biggestSum = (sum > biggestSum) ? sum : biggestSum;
        }

        Console.WriteLine("max sum = {0}", biggestSum);
    }
}