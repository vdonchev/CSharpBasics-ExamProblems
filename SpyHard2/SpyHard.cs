using System;
using System.Text;

class SpyHard
{
    static void Main()
    {
        // input
        int key = int.Parse(Console.ReadLine());
        string msg = Console.ReadLine().ToUpper(); // set all letters to upper

        string output = string.Empty;

        int msgSum = 0;
        for (int i = 0; i < msg.Length; i++)
        {
            if (char.IsLetter(msg[i]))
            {
                msgSum += msg[i] - 64;
            }
            else
            {
                msgSum += msg[i];
            }
        }

        // convert to numeral sys
        
        StringBuilder convertedMsg = new StringBuilder();

        while (msgSum > 0)
        {
            convertedMsg.Insert(0, msgSum % key);
            msgSum /= key;
        }

        // add numeral sys and msg length to the output
        output += key;
        output += msg.Length;
        output += convertedMsg;

        Console.WriteLine(output);
    }
}