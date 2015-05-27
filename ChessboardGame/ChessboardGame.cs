using System;

class ChessboardGame
{
    static void Main()
    {
        // inputs
        int boardSize = int.Parse(Console.ReadLine());
        string phrase = Console.ReadLine();

        // logic
        int phraseLength = phrase.Length;
        int whiteTeam = 0;
        int blackTeam = 0;

        for (int step = 0; step < phraseLength; step++)
        {
            if (char.IsLetterOrDigit(phrase[step]))
            {
                if (step >= boardSize * boardSize)
                {
                    break;
                }

                if (step % 2 == 0)
                {
                    if (char.IsUpper(phrase[step]))
                    {
                        whiteTeam += phrase[step];
                    }
                    else
                    {
                        blackTeam += phrase[step];
                    }
                }
                else
                {
                    if (char.IsUpper(phrase[step]))
                    {
                        blackTeam += phrase[step];
                    }
                    else
                    {
                        whiteTeam += phrase[step];
                    }
                }
            }
        }

        // output
        if (blackTeam == whiteTeam)
        {
            Console.WriteLine("Equal result: {0}", blackTeam);
        }
        else
        {
            string winner = (blackTeam > whiteTeam) ? "black" : "white";
            int diff = Math.Abs(blackTeam - whiteTeam);
            Console.WriteLine("The winner is: {0} team", winner);
            Console.WriteLine(diff);
        }
    }
}