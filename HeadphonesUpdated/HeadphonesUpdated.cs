using System;

class HeadphonesUpdated
{
    static void Main()
    {
        // inputs
        int diameter = 9;

        //print top
        for (int i = 0; i < diameter; i++)
        {
            char bg = '-';
            if(i == 0)
            {
                bg = '*';
            }
            Console.WriteLine("{0}*{1}*{0}", new string('-', diameter / 2), new string(bg, diameter));
        }

        // print phones
        int backCount = diameter / 2;
        int foreCount = 1;
        for (int i = 0; i < diameter; i++)
        {
            Console.WriteLine("{0}{1}{0}-{0}{1}{0}", new string('-', backCount), new string('*', foreCount));
            if(i < diameter / 2)
            {
                backCount--;
                foreCount += 2;
            }
            else
            {
                backCount++;
                foreCount -= 2;
            }
        }
    }

}