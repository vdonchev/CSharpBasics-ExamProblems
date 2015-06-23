using System;

class HayvanNumbers
{
    static void Main()
    {
        int a = int.Parse('a'.ToString());

        // inputs
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 555; i <= 999; i++)
        {
            int num1 = i;
            int num2 = i + diff;
            int num3 = i + (diff * 2);

            string num = "" + num1 + num2 + num3;

            if (num1 <= num2 && num2 <= num3 && num3 <= 999 && IsValidNum(num))
            {

                int currSum = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    currSum += int.Parse(num[j].ToString());
                }

                if (currSum == sum)
                {
                    found = true;
                    Console.WriteLine(num);
                }
            }
        }

        if (found == false)
        {
            Console.WriteLine("No");
        }
    }

    private static bool IsValidNum(string num)
    {
        bool ok = true;
        for (int i = 0; i < num.Length; i++)
        {
            if (int.Parse(num[i].ToString()) < 5)
            {
                ok = false;
            }
        }
        return ok;
    }
}