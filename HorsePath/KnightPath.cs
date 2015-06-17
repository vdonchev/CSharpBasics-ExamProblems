using System;

class KnightPath
{
    static void Main()
    {
        // create the board
        int[] board = new int[8];

        for (int i = 0; i < 8; i++)
        {
            board[i] = 0;
        }

        // set the start position
        board[0] = 1;

        int row = 0;
        int col = 0;

        // get the first command
        string[] command = Console.ReadLine().Split(' ');

        // keep getting commands until "stop"
        while (command[0] != "stop")
        {
            string move1 = command[0];
            string move2 = command[1];

            if (IsMovePossible(row, col, move1, move2))
            {
                switch (move1)
                {
                    case "left":
                        col += 2;
                        break;
                    case "right":
                        col -= 2;
                        break;
                    case "up":
                        row -= 2;
                        break;
                    case "down":
                        row += 2;
                        break;
                }

                switch (move2)
                {
                    case "left":
                        col += 1;
                        break;
                    case "right":
                        col -= 1;
                        break;
                    case "up":
                        row -= 1;
                        break;
                    case "down":
                        row += 1;
                        break;
                }

                // switch the bit
                board[row] = board[row] ^ (1 << col);
            }

            command = Console.ReadLine().Split(' ');
        }

        // print the result
        int matches = 0;
        for (int i = 0; i < 8; i++)
        {
            if (board[i] != 0)
            {
                Console.WriteLine(board[i]);
                matches++;
            }
        }

        if (matches == 0)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    private static bool IsMovePossible(int row, int col, string com1, string com2)
    {
        switch (com1)
        {
            case "left":
                col += 2;
                break;
            case "right":
                col -= 2;
                break;
            case "up":
                row -= 2;
                break;
            case "down":
                row += 2;
                break;
        }

        if (col > 7 || col < 0 || row > 7 || row < 0)
        {
            return false;
        }

        switch (com2)
        {
            case "left":
                col += 1;
                break;
            case "right":
                col -= 1;
                break;
            case "up":
                row -= 1;
                break;
            case "down":
                row += 1;
                break;
        }

        if (col > 7 || col < 0 || row > 7 || row < 0)
        {
            return false;
        }

        return true;
    }
}