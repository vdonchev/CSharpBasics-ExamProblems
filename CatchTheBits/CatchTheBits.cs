using System;

public class CatchTheBits
{
    static void Main(string[] args)
    {
        int bits = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        string output = String.Empty;
        string array = String.Empty;

        for (int i = 0; i < bits; i++)
        {
            var digit = int.Parse(Console.ReadLine());
            array += Convert.ToString(digit, 2).PadLeft(8, '0');
        }

        for (int i = 1; i < array.Length; i += step)
        {
            output += array[i];
            if (output.Length >= 8)
            {
                Console.WriteLine(Convert.ToInt32(output, 2));
                output = String.Empty;
            }
        }

        if (output.Length > 0)
        {
            while (output.Length != 8)
            {
                output += 0;
            }
            Console.WriteLine(Convert.ToInt32(output, 2));
        }
    }
}