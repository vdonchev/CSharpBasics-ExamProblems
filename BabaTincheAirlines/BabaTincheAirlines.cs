using System;

class BabaTincheAirlines
{
    static void Main()
    {
        // inputs
        string[] firstClass = Console.ReadLine().Split();
        string[] secondClass = Console.ReadLine().Split();
        string[] thirdClass = Console.ReadLine().Split();

        // calculate
        int firstClassFreqIncome = (int)Convert.ToInt32(firstClass[1]) * (int)(7000 * 0.3);
        int firstClassRegIncome = (int)(Convert.ToInt32(firstClass[0]) - Convert.ToInt32(firstClass[1])) * 7000;
        int firstClassIncome = (int)Convert.ToInt32(firstClass[2]) * (int)(0.005 * 7000);
        int totalIncomeFirstClass = firstClassFreqIncome + firstClassRegIncome + firstClassIncome;

        int secondClassFreqIncome = (int)Convert.ToInt32(secondClass[1]) * (int)(3500 * 0.3);
        int secondClassRegIncome = (int)(Convert.ToInt32(secondClass[0]) - Convert.ToInt32(secondClass[1])) * 3500;
        int secondClassIncome = (int)Convert.ToInt32(secondClass[2]) * (int)(0.005 * 3500);
        int totalIncomeSecondClass = secondClassFreqIncome + secondClassRegIncome + secondClassIncome;

        int thirdClassFreqIncome = (int)Convert.ToInt32(thirdClass[1]) * (int)(1000 * 0.3);
        int thirdClassRegIncome = (int)(Convert.ToInt32(thirdClass[0]) - Convert.ToInt32(thirdClass[1])) * 1000;
        int thirdClassIncome = (int)Convert.ToInt32(thirdClass[2]) * (int)(0.005 * 1000);
        int totalIncomeThirdClass = thirdClassFreqIncome + thirdClassRegIncome + thirdClassIncome;

        int allIncome = totalIncomeFirstClass + totalIncomeSecondClass + totalIncomeThirdClass;
        Console.WriteLine(allIncome);
    }
}