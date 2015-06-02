using System;

class TorrentPirate
{
    static void Main()
    {
        int downloadTraffic = int.Parse(Console.ReadLine());
        int cinemaCost = int.Parse(Console.ReadLine());
        int wifeSpending = int.Parse(Console.ReadLine());

        double priceForDownload = (downloadTraffic / 2D / 60D / 60D) * wifeSpending;
        double cinemaPrice = (downloadTraffic / 1500D) * cinemaCost;

        double priceToPay = (priceForDownload > cinemaPrice) ? cinemaPrice : priceForDownload;
        string placeToGo = (priceForDownload > cinemaPrice) ? "cinema" : "mall";

        Console.WriteLine("{0} -> {1:F2}lv", placeToGo, priceToPay);
    }
}