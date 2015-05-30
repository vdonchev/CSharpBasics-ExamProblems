using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int sets = int.Parse(Console.ReadLine());
        int numbers = int.Parse(Console.ReadLine());
        string needle = Console.ReadLine();

        int highSet = 0;
        int needleCount = 0;

        for (int i = 1; i <= sets; i++)
        {
            int currentNeedleCount = 0;
            for (int j = 0; j < numbers; j++)
            {
                int number = int.Parse(Console.ReadLine());

                if(needle == "odd")
                {
                    if (number % 2 != 0)
                    {
                        currentNeedleCount++;
                    }
                }
                else
                {
                    if(number % 2 == 0) 
                    {
                        currentNeedleCount++;
                    }
                }
            }
            if (currentNeedleCount > needleCount)
            {
                highSet = i;
                needleCount = currentNeedleCount;
            }
        }

        string ordinal = "No";

        switch (highSet)
        {
            case 1:
                ordinal = "First";
                break;
            case 2:
                ordinal = "Second";
                break;
            case 3:
                ordinal = "Third";
                break;
            case 4:
                ordinal = "Fourth";
                break;
            case 5:
                ordinal = "Fifth";
                break;
            case 6:
                ordinal = "Sixth";
                break;
            case 7:
                ordinal = "Seventh";
                break;
            case 8:
                ordinal = "Eighth";
                break;
            case 9:
                ordinal = "Nineth";
                break;
            case 10:
                ordinal = "Tenth";
                break;
        }

        if (ordinal == "No")
        {
            Console.WriteLine(ordinal);
        }
        else
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal, needle, needleCount);
        }
    }
}