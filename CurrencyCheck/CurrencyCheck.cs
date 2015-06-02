using System;

class CurrencyCheck
{
    static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euros = decimal.Parse(Console.ReadLine());
        decimal levaBundle = decimal.Parse(Console.ReadLine());
        decimal leva = decimal.Parse(Console.ReadLine());

        decimal rublesPrice = (rubles / 100) * 3.5M;
        decimal usdPrice = dollars * 1.5M;
        decimal euroPrice = euros * 1.95M;
        decimal bundlePrice = levaBundle / 2;
        decimal levaPrice = leva;

        Console.WriteLine("{0:F2}", Math.Min(rublesPrice, Math.Min(usdPrice, Math.Min(euroPrice, Math.Min(bundlePrice, leva)))));
    }
}