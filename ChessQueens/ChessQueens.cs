using System;

class ChessQueens
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        int dist = int.Parse(Console.ReadLine());
        int psuedoDist = dist + 1;
        bool found = false;

        for (int x = 1; x <= boardSize; x++)
        {
            for (int y = 1; y <= boardSize; y++)
            {
                bool top = (y - psuedoDist >= 1);
                bool bottom = (y + psuedoDist <= boardSize);
                bool left = (x - psuedoDist >= 1);
                bool right = (x + psuedoDist <= boardSize);

                if (top || bottom || right || left)
                {
                    found = true;
                }

                if (top)
                {
                    PrintPositions(x, y, x, y - psuedoDist);
                }
                if (bottom)
                {
                    PrintPositions(x, y, x, y + psuedoDist);
                }
                if (left)
                {
                    PrintPositions(x, y, x - psuedoDist, y);
                }
                if (right)
                {
                    PrintPositions(x, y, x + psuedoDist, y);
                }
                if (top && right)
                {
                    PrintPositions(x, y, x + psuedoDist, y - psuedoDist);
                }
                if (top && left)
                {
                    PrintPositions(x, y, x - psuedoDist, y - psuedoDist);
                }
                if (bottom && right)
                {
                    PrintPositions(x, y, x + psuedoDist, y + psuedoDist);
                }
                if (bottom && left)
                {
                    PrintPositions(x, y, x - psuedoDist, y + psuedoDist);
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No valid positions");
        }
    }

    static void PrintPositions(int x1, int y1, int x2, int y2)
    {
        string queen1 = "" + (char)(x1 + 96) + y1;
        string queen2 = "" + (char)(x2 + 96) + y2;
        Console.WriteLine("{0} - {1}", queen1, queen2);
    }
}