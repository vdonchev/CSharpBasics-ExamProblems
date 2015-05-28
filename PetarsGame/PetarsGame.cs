using System;

class PetarsGame
{
    static void Main()
    {
        //inputs
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();

        ulong totalSum = 0;
        for (ulong i = startNumber; i < endNumber; i++)
        {
            if(i % 5 == 0)
            {
                totalSum += i;
            }
            else
            {
                totalSum += i % 5;
            }
        }

        string a = totalSum.ToString();
        string forReplace;

        if(totalSum % 2 != 0)
        {
            forReplace = a[a.Length - 1].ToString();
        }
        else
        {
            forReplace = a[0].ToString();
        }

        //Console.WriteLine(totalSum);
        string b = a.Replace(forReplace, replacement);
        Console.WriteLine(b);
    }
}