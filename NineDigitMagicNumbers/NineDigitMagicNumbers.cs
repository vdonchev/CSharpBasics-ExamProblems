using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int results = 0;
        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;
            if (isAllowed(num1) && isAllowed(num2) && isAllowed(num3) && (num3 <= 777) && (isRightSum(num1) + isRightSum(num2) + isRightSum(num3) == sum))
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                results++;
            }
        }
        if (results == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int isRightSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }

    private static bool isAllowed(int num)
    {
        string digits = num.ToString();
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
}