using System;

namespace BasketBattle
{
    class BasketBattle
    {
        private static void Main()
        {
            string homePlayer = Console.ReadLine();
            string awayPlayer = (homePlayer == "Simeon") ? "Nakov" : "Simeon";
            int rounds = int.Parse(Console.ReadLine());

            int homeScore = 0;
            int awayScore = 0;

            for (int i = 0; i < rounds; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int scoreTry = int.Parse(Console.ReadLine());
                        string scoreResult = Console.ReadLine();

                        if (scoreResult == "success")
                        {
                            homeScore += (j == 0) ? (homeScore + scoreTry <= 500) ? scoreTry : 0 : 0;
                            awayScore += (j == 1) ? (awayScore + scoreTry <= 500) ? scoreTry : 0 : 0;
                        }

                        if (homeScore > awayScore && homeScore == 500)
                        {
                            Console.WriteLine(homePlayer);
                            Console.WriteLine(i + 1);
                            Console.WriteLine(awayScore);
                            return;
                        }
                        else if (homeScore < awayScore && awayScore == 500)
                        {
                            Console.WriteLine(awayPlayer);
                            Console.WriteLine(i + 1);
                            Console.WriteLine(homeScore);
                            return;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int scoreTry = int.Parse(Console.ReadLine());
                        string scoreResult = Console.ReadLine();

                        if (scoreResult == "success")
                        {
                            homeScore += (j == 1) ? (homeScore + scoreTry <= 500) ? scoreTry : 0 : 0;
                            awayScore += (j == 0) ? (awayScore + scoreTry <= 500) ? scoreTry : 0 : 0;
                        }

                        if (homeScore > awayScore && homeScore == 500)
                        {
                            Console.WriteLine(homePlayer);
                            Console.WriteLine(i + 1);
                            Console.WriteLine(awayScore);
                            return;
                        }
                        else if (homeScore < awayScore && awayScore == 500)
                        {
                            Console.WriteLine(awayPlayer);
                            Console.WriteLine(i + 1);
                            Console.WriteLine(homeScore);
                            return;
                        }
                    }
                }
            }

            if (homeScore == awayScore)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(homeScore);
            }
            else
            {
                string winner = (homeScore > awayScore) ? homePlayer : awayPlayer;
                Console.WriteLine(winner);
                Console.WriteLine(Math.Abs(homeScore - awayScore));
            }
        }
    }
}