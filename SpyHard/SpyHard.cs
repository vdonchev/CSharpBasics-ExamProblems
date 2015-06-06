using System;

namespace SpyHard
{
    class SpyHard
    {
        static void Main()
        {
            int numSystem = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();

            string output = string.Empty;
            int messageCrypt = 0;
            char messageChar;

            output += numSystem;
            output += message.Length;


            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    messageChar = char.ToLower(message[i]);
                    messageCrypt += (messageChar - 96);
                }
                else
                {
                    messageCrypt += (int) message[i];
                }
            }
            output += Convert.ToString(messageCrypt, numSystem);
            Console.WriteLine(output);
        }
    }
}
