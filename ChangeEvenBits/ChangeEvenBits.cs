using System;

class ChangeEvenBits
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] nums = new int[count];
        int bitChanges = 0;

        for (int i = 0; i < count; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        long theNumber = long.Parse(Console.ReadLine());

        for (int i = 0; i < nums.Length; i++)
        {
            int evens = Convert.ToString(nums[i], 2).Length;

            int evenCounter = 0;
            for (int j = 0; j < evens; j++)
            {
                if ((theNumber >> evenCounter & 1) == 0)
                {
                    theNumber |= 1 << evenCounter;
                    bitChanges++;
                }

                evenCounter += 2;
            }
        }

        Console.WriteLine(theNumber);
        Console.WriteLine(bitChanges);
    }
}