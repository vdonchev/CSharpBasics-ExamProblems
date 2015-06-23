using System;

class Program
{
    static void Main()
    {
        // inputs
        int size = int.Parse(Console.ReadLine());
        string phrase = Console.ReadLine();

        // prepare the matrix
        char[,] matrix = new char[size, size];

        // set borders
        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;
        int dir = 0;

        int chaIndex = 0;

        // fill the matrix
        while (top <= bottom && left <= right)
        {
            if (dir == 0)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = CharGenerator(chaIndex++, phrase);
                }
                top++;
            }
            else if (dir == 1)
            {
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = CharGenerator(chaIndex++, phrase);
                }
                right--;
            }
            else if (dir == 2)
            {
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = CharGenerator(chaIndex++, phrase);
                }
                bottom--;
            }
            else if (dir == 3)
            {
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = CharGenerator(chaIndex++, phrase);
                }
                left++;
            }
            dir++;
            dir %= 4;
        }

        // calculate the biggest row
        int biggestSum = 0;
        int biggestRow = 0;

        for (int row = 0; row < size; row++)
        {
            int currSum = 0;
            for (int col = 0; col < size; col++)
            {
                char currChar = char.ToUpper(matrix[row, col]);
                currSum += (currChar - 64) * 10;
            }

            if (currSum > biggestSum)
            {
                biggestSum = currSum;
                biggestRow = row;
            }
        }

        Console.WriteLine("{0} - {1}", biggestRow, biggestSum);
    }

    private static char CharGenerator(int index, string phrase)
    {
        int currIndex = index % phrase.Length;
        char output = phrase[currIndex];
        return output;
    }
}