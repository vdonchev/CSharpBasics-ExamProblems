using System;
using System.Collections.Generic;

class KSequence
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        int step = int.Parse(Console.ReadLine());

        for (int i = 0; i <= nums.Length - step + 1; i++)
        {
            int currNum = int.Parse(nums[i]);
            bool equal = true;
            for (int j = 1; j <= step; j++)
            {
                int nextNum = int.Parse(nums[i + j]);

                if (nextNum != currNum)
                {
                    //Console.WriteLine(currNum);
                    //break;
                    equal = false;
                }
            }
            if (!equal)
            {
                Console.Write(currNum + " ");
            }
            else
            {
                i += step - 1;
            }
        }

        for (int i = nums.Length - step; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}