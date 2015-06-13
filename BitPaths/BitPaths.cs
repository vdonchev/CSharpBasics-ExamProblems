using System;

class BitPaths
{
    static void Main()
    {
        int paths = int.Parse(Console.ReadLine());

        // create and fill a matrix
        int[,] matrix = new int[8, 4];
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix[row, col] = 0;
            }
        }

        // loop trough the paths
        for (int i = 0; i < paths; i++)
        {
            string[] path = Console.ReadLine().Split(',');
            int pathCol = int.Parse(path[0]);

            for (int row = 0; row < 8; row++)
            {
                if (row > 0)
                {
                    pathCol += int.Parse(path[row]);
                }

                if (matrix[row, pathCol] == 0)
                {
                    matrix[row, pathCol] = 1;
                }
                else
                {
                    matrix[row, pathCol] = 0;
                }
            }
        }

        // sum all rows
        int totalSum = 0;
        int rowSum = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                rowSum = rowSum << 1;
                rowSum = rowSum | matrix[row, col];
            }

            totalSum += rowSum;
            rowSum = 0;
        }

        Console.WriteLine(Convert.ToString(totalSum, 2));
        Console.WriteLine(Convert.ToString(totalSum, 16).ToUpper());
    }
}