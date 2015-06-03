using System;

public class DecryptТheMessages
{
    static void Main()
    {
        string message = Console.ReadLine();

        int messages = 0;
        string messageTemp = "";
        string messageDecrypted = "";

        while (message != null && message.ToLower() != "start")
        {
            message = Console.ReadLine();
        }

        message = "";

        while (message.ToLower() != "end")
        {
            if (message != "" && message.ToLower() != "end" && !string.IsNullOrWhiteSpace(message))
            {
                for (int i = 0; i < message.Length; i++)
                {
                    if (Char.IsLetter(message[i]))
                    {
                        if (message[i] >= 'a' && message[i] < 'n' || message[i] >= 'A' && message[i] < 'N')
                        {
                            messageTemp += (char)(message[i] + 13);
                        }
                        else if (message[i] >= 'n' && message[i] <= 'z' || message[i] >= 'N' && message[i] <= 'Z')
                        {
                            messageTemp += (char)(message[i] - 13);
                        }
                    }
                    else if (Char.IsDigit(message[i]))
                    {
                        messageTemp += message[i];
                    }
                    else
                    {
                        switch (message[i])
                        {
                            case '+':
                                messageTemp += ' ';
                                break;
                            case '%':
                                messageTemp += ',';
                                break;
                            case '&':
                                messageTemp += '.';
                                break;
                            case '#':
                                messageTemp += '?';
                                break;
                            case '$':
                                messageTemp += '!';
                                break;
                            default:
                                messageTemp += message[i]; // it should not but anyway...
                                break;
                        }
                    }
                }

                char[] temp = messageTemp.ToCharArray();
                Array.Reverse(temp);
                messageDecrypted += new string(temp);
                messageDecrypted += Environment.NewLine;
                messages++;
                messageTemp = "";
            }

            message = Console.ReadLine();
        }
        if (messages > 0)
        {
            Console.WriteLine("Total number of messages: {0}", messages);
            Console.WriteLine(messageDecrypted);
        }
        else
        {
            Console.WriteLine("No message received.");
        }
    }
}