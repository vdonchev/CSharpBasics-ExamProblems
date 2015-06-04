using System;

namespace BitsInverter
{
    class BitsInverter
    {
        static void Main()
        {
            int bytes = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string bits = string.Empty;

            for (int i = 0; i < bytes; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                bits += Convert.ToString(digit, 2).PadLeft(8, '0');
            }

            for (int i = 0; i < bits.Length; i += step)
            {
                bits = bits.Remove(i, 1).Insert(i, (bits[i] == '0') ? "1" : "0");
            }

            string output = string.Empty;
            for (int i = 0; i < bits.Length; i++)
            {
                output += bits[i];
                if (output.Length == 8)
                {
                    Console.WriteLine(Convert.ToInt32(output, 2));
                    output = string.Empty;
                }
            }
        }
    }
}