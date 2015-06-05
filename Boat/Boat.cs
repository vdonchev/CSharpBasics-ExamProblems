using System;

class BoatV2
{
    static void Main()
    {
        //inputs
        int height = int.Parse(Console.ReadLine());
        int BoatHeight = (height - 1) / 2;

        //print sail
        int sailInner = 1;
        int sailOutter = height - 1;
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('_', sailOutter), new string('&', sailInner), new string('_', height));
            if (i < height / 2)
            {
                sailInner += 2;
                sailOutter -= 2;
            }
            else
            {
                sailInner -= 2;
                sailOutter += 2;
            }
        }

        //print boat
        int boatInner = height * 2;
        int boatOutter = 0;
        for (int i = 0; i < BoatHeight; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('_', boatOutter), new string('&', boatInner));
            boatInner -= 2;
            boatOutter++;
        }
    }
}