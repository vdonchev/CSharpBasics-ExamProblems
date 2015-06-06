using System;

class BitsUp
{
    static void Main()
    {
        int bytes = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string output = string.Empty;

        int bitSum = 0;
        for (int i = 0; i < bytes; i++)
        {
            int digit = int.Parse(Console.ReadLine());
            string byteToBits = Convert.ToString(digit, 2).PadLeft(8, '0');

            for (int j = 0; j < byteToBits.Length; j++)
            {
                if (i == 0 && j == 1)
                {
                    byteToBits = byteToBits.Remove(j, j).Insert(j, "1");
                    bitSum = 0;
                }
                else if (i == 0 && j < 1)
                {
                    continue;
                }
                else
                {
                    bitSum++;
                }

                if (bitSum == step)
                {
                    byteToBits = byteToBits.Remove(j, 1).Insert(j, "1");
                    bitSum = 0;
                }
            }

            output += Convert.ToInt32(byteToBits, 2);
            output += (i == bytes - 1) ? "" : Environment.NewLine;
        }

        Console.WriteLine(output);
    }
}