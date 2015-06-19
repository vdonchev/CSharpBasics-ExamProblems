using System;

class XBits
{
    static void Main()
    {
        int[] nums = new int[8];

        for (int i = 0; i < 8; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int found = 0;

        // loop through nums
        for (int num = 0; num < 6; num++)
        {
            
            // loop through bits
            for (int bit = 0; bit < 32; bit++)
            {
                if ((nums[num] >> bit & 7) == 5 && (nums[num + 1] >> bit & 7) == 2 && (nums[num + 2] >> bit & 7) == 5)
                {
                    found++;
                }
            }
        }

        Console.WriteLine(found);
    }
}