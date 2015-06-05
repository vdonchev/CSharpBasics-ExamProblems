using System;

class EncryptedMatrix
{
    private static void Main()
    {
        string message = Console.ReadLine();
        int messagesCount = 0;
        string singleMessage = String.Empty;
        string encryptedMessages = String.Empty;

        while (message.ToLower() != "start")
        {
            message = Console.ReadLine();
        }

        message = string.Empty;

        while (message.ToLower() != "end")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                for (int i = message.Length - 1; i >= 0; i--)
                {
                    if (char.IsLetter(message[i]))
                    {
                        if (message[i] >= 'a' && message[i] <= 'm' || message[i] >= 'A' && message[i] <= 'M')
                        {
                            singleMessage += (char)(message[i] + 13);
                        }
                        else
                        {
                            singleMessage += (char)(message[i] - 13);
                        }
                    }
                    else if (char.IsDigit(message[i]))
                    {
                        singleMessage += message[i];
                    }
                    else
                    {
                        switch (message[i])
                        {
                            case ' ':
                                singleMessage += '+';
                                break;
                            case ',':
                                singleMessage += '%';
                                break;
                            case '.':
                                singleMessage += '&';
                                break;
                            case '?':
                                singleMessage += '#';
                                break;
                            case '!':
                                singleMessage += '$';
                                break;
                            default:
                                singleMessage += message[i];
                                break;
                        }
                    }
                }
                encryptedMessages += singleMessage + Environment.NewLine;
                messagesCount++;
                singleMessage = string.Empty;
                message = Console.ReadLine();
            }
            else
            {
                message = Console.ReadLine();
                continue;
            }
        }
        if (messagesCount > 0)
        {
            Console.WriteLine("Total number of messages: {0}", messagesCount);
            Console.WriteLine(encryptedMessages);
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
    }
}