using System;

class FruitMarket
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        string day = Console.ReadLine();
        double totalIncome = 0;

        for (int i = 0; i < 3; i++)
        {
            double fruitQuanty = Double.Parse(Console.ReadLine());
            string fruitType = Console.ReadLine();
            double fruitIncome = 0;
            switch (fruitType)
            {
                case "banana":
                    fruitIncome = fruitQuanty * 1.80;
                    break;
                case "cucumber":
                    fruitIncome = fruitQuanty * 2.75;
                    break;
                case "tomato":
                    fruitIncome = fruitQuanty * 3.20;
                    break;
                case "orange":
                    fruitIncome = fruitQuanty * 1.60;
                    break;
                case "apple":
                    fruitIncome = fruitQuanty * 0.86;
                    break;
            }

            switch (day)
            {
                case "Friday":
                    fruitIncome -= fruitIncome * 0.10;
                    break;
                case "Sunday":
                    fruitIncome -= fruitIncome * 0.05;
                    break;
                case "Tuesday":
                    switch (fruitType)
                    {
                        case "banana":
                        case "orange":
                        case "apple":
                            fruitIncome -= fruitIncome * 0.20;
                            break;
                    }
                    break;
                case "Wednesday":
                    switch (fruitType)
                    {
                        case "cucumber":
                        case "tomato":
                            fruitIncome -= fruitIncome * 0.10;
                            break;
                    }
                    break;
                case "Thursday":
                    if (fruitType == "banana")
                    {
                        fruitIncome -= fruitIncome * 0.30;
                    }
                    break;
            }

            totalIncome += fruitIncome;

        }
        Console.WriteLine("{0:F2}", totalIncome);
    }
}