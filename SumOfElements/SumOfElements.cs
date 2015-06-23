using System;
using System.Linq;
using System.Numerics;

class SumOfElements
{
    static void Main()
    {
        // input
        string[] allNums = Console.ReadLine().Split();
        ulong sum = 0;

        for (int i = 0; i < allNums.Length; i++)
        {
            ulong currNum = ulong.Parse(allNums[i]);
            for (int j = 0; j < allNums.Length; j++)
            {
                if (j != i)
                {
                    sum += ulong.Parse(allNums[j]);
                }
            }
            if (sum == currNum)
            {
                Console.WriteLine(currNum);
            }
            sum = 0;
        }


    }
}