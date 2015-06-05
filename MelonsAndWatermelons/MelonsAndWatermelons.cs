using System;

class MelonsAndWatermelons
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int duration = int.Parse(Console.ReadLine());

        int melons = 0;
        int waterMelons = 0;

        for (int i = 1; i <= duration; i++)
        {
            if (start > 7)
            {
                start = 1;
            }

            switch (start)
            {
                case 1:
                    waterMelons++;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    waterMelons++;
                    melons++;
                    break;
                case 4:
                    waterMelons += 2;
                    break;
                case 5:
                    waterMelons += 2;
                    melons += 2;
                    break;
                case 6:
                    waterMelons++;
                    melons += 2;
                    break;
                case 7:
                    break;
            }
            start++;
        }
        if (waterMelons == melons)
        {
            Console.WriteLine("Equal amount: {0}", waterMelons);
        }
        else if (waterMelons > melons)
        {
            Console.WriteLine("{0} more watermelons", waterMelons - melons);
        }
        else
        {
            Console.WriteLine("{0} more melons", melons - waterMelons);
        }
    }
}