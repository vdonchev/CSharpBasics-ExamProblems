using System;

class HalfByteSwapper
{
    static void Main()
    {
        uint[] nums = new uint[4];

        for (int i = 0; i < 4; i++)
        {
            nums[i] = uint.Parse(Console.ReadLine());
        }

        string[] command1 = Console.ReadLine().Split();
        if (command1[0] == "End")
        {
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            return;
        }

        string[] command2 = Console.ReadLine().Split();


        while (command1[0] != "End")
        {
            int num1 = int.Parse(command1[0]);
            int group1 = int.Parse(command1[1]) * 4;
            int num2 = int.Parse(command2[0]);
            int group2 = int.Parse(command2[1]) * 4;

            for (int i = 0; i < 4; i++)
            {
                uint bit = nums[num1] >> (group1 + i) & 1;
                uint bit2 = nums[num2] >> (group2 + i) & 1;

                if (bit == 0)
                {
                    nums[num2] &= ~(1u << (group2 + i));
                }
                else
                {
                    nums[num2] |= 1u << (group2 + i);
                }

                if (bit2 == 0)
                {
                    nums[num1] &= ~(1u << (group1 + i));
                }
                else
                {
                    nums[num1] |= 1u << (group1 + i);
                }
            }

            command1 = Console.ReadLine().Split();
            if (command1[0] == "End")
            {
                break;
            }
            command2 = Console.ReadLine().Split();
        }

        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}