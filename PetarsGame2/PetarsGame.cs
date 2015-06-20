using System;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        // inputs
        ulong start = ulong.Parse(Console.ReadLine());
        ulong stop = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();

        BigInteger sum = 0; // store biggest values than ulong

        for (ulong i = start; i < stop; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        string sumString = Convert.ToString(sum);
        int last = sumString.Length - 1;
        char replaced; 

        if (sum % 2 == 1) // odd
        {
            replaced = sumString[last];
        }
        else // even
        {
            replaced = sumString[0];
        }

        for (int i = 0; i < sumString.Length; i++)
        {
            if (sumString[i] == replaced)
            {
                Console.Write(replacement);
            }
            else
            {
                Console.Write(sumString[i]);
            }
        }
        Console.WriteLine();
    }
}