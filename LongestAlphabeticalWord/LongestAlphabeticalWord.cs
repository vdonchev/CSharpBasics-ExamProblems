using System;
using System.Data;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string phrase = Console.ReadLine();
        int matrixSize = int.Parse(Console.ReadLine());

        int phraseLenth = phrase.Length;
        int index = 0;

        char[,] matrix = new char[matrixSize, matrixSize];

        // fill the matrix
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = phrase[index];
                index++;
                if (index == phraseLenth)
                {
                    index = 0;
                }
            }
        }
        string longest = String.Empty;
        string temp = String.Empty;


        // top-bottom
        for (int col = 0; col < matrixSize; col++)
        {
            int step = 0;
            char prev = matrix[0, col];

            for (int row = 0; row < matrixSize; row++)
            {
                if (step == 0)
                {
                    prev = matrix[row, col];
                    step++;
                    temp += prev;
                }
                else
                {
                    char curr = matrix[row, col];
                    if (curr > prev)
                    {
                        step++;
                        temp += curr;
                        prev = curr;
                    }
                    else
                    {
                        step = 0;
                        longest = findLongest(longest, temp);
                        temp = String.Empty;
                    }
                }
            }
            longest = findLongest(longest, temp);
            temp = String.Empty;
        }

        // bottom-top
        for (int col = 0; col < matrixSize; col++)
        {
            int step = 0;
            char prev = matrix[matrixSize - 1, col];

            for (int row = matrixSize - 1; row >= 0; row--)
            {
                if (step == 0)
                {
                    prev = matrix[row, col];
                    step++;
                    temp += prev;
                }
                else
                {
                    char curr = matrix[row, col];
                    if (curr > prev)
                    {
                        step++;
                        temp += curr;
                        prev = curr;
                    }
                    else
                    {
                        step = 0;
                        longest = findLongest(longest, temp);
                        temp = String.Empty;
                    }
                }
            }
            longest = findLongest(longest, temp);
            temp = String.Empty;
        }

        // left-right
        for (int row = 0; row < matrixSize; row++)
        {
            int step = 0;
            char prev = matrix[row, matrixSize - 1];

            for (int col = matrixSize - 1; col >= 0; col--)
            {
                if (step == 0)
                {
                    prev = matrix[row, col];
                    step++;
                    temp += prev;
                }
                else
                {
                    char curr = matrix[row, col];
                    if (curr > prev)
                    {
                        step++;
                        temp += curr;
                        prev = curr;
                    }
                    else
                    {
                        step = 0;
                        longest = findLongest(longest, temp);
                        temp = String.Empty;
                    }
                }
            }
            longest = findLongest(longest, temp);
            temp = String.Empty;
        }

        // right-left
        for (int row = 0; row < matrixSize; row++)
        {
            int step = 0;
            char prev = matrix[row, 0];

            for (int col = 0; col < matrixSize; col++)
            {
                if (step == 0)
                {
                    prev = matrix[row, col];
                    step++;
                    temp += prev;
                }
                else
                {
                    char curr = matrix[row, col];
                    if (curr > prev)
                    {
                        step++;
                        temp += curr;
                        prev = curr;
                    }
                    else
                    {
                        step = 0;
                        longest = findLongest(longest, temp);
                        temp = String.Empty;
                    }
                }
            }
            longest = findLongest(longest, temp);
            temp = String.Empty;
        }

        Console.WriteLine(longest);


        // debug
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static string findLongest(string longest, string currLongest)
    {
        if (currLongest.Length > longest.Length)
        {
            return currLongest;
        }

        if (currLongest.Length == longest.Length)
        {
            for (int i = 0; i < currLongest.Length; i++)
            {
                if (currLongest[i] != longest[i])
                {
                    return (currLongest[i] > longest[i]) ? longest : currLongest;
                }
            }
        }

        return longest;
    }
}