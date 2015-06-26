using System;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int matrixSize = int.Parse(Console.ReadLine());

        char[] wordByChars = word.ToCharArray();
        char[,] matrix = new char[matrixSize, matrixSize];

        // fill the matrix
        int index = 0;
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = wordByChars[index % word.Length];
                index++;
                //Console.Write(matrix[row, col]);
            }
            //Console.WriteLine();
        }

        string longestWord = string.Empty;

        // check left-to-right
        for (int x = 0; x < matrixSize; x++)
        {
            string wordX = "";
            for (int y = 0; y < matrixSize; y++)
            {
                wordX += matrix[x, y];
            }

            string curLongest = CheckWord(wordX);
            longestWord = CompareWords(longestWord, curLongest);
        }

        // check right-to-left
        for (int x = 0; x < matrixSize; x++)
        {
            string wordX = "";
            for (int y = matrixSize - 1; y >= 0; y--)
            {
                wordX += matrix[x, y];
            }

            string curLongest = CheckWord(wordX);
            longestWord = CompareWords(longestWord, curLongest);
        }

        // check top-to-bottom
        for (int y = 0; y < matrixSize; y++)
        {
            string wordX = "";
            for (int x = 0; x < matrixSize; x++)
            {
                wordX += matrix[x, y];
            }

            string curLongest = CheckWord(wordX);
            longestWord = CompareWords(longestWord, curLongest);
        }

        // check bottom-to-top
        for (int y = 0; y < matrixSize; y++)
        {
            string wordX = "";
            for (int x = matrixSize - 1; x >= 0; x--)
            {
                wordX += matrix[x, y];
            }

            string curLongest = CheckWord(wordX);
            longestWord = CompareWords(longestWord, curLongest);
        }

        Console.WriteLine(longestWord);

    }

    static string CompareWords(string longest, string currLongest)
    {
        if (longest.Length > currLongest.Length)
        {
            return longest;
        }
        if (longest.Length < currLongest.Length)
        {
            return currLongest;
        }

        for (int i = 0; i < longest.Length; i++)
        {
            if (longest[i] < currLongest[i])
            {
                return longest;
            }
            if (longest[i] > currLongest[i])
            {
                return currLongest;
            }
        }
        return longest;
    }

    static string CheckWord(string word)
    {
        string longest = "";
        for (int i = 0; i < word.Length; i++)
        {
            char prevChar = word[i];
            string curLongest = "" + prevChar;
            for (int j = i + 1; j < word.Length; j++)
            {
                char currChar = word[j];
                if (prevChar < currChar)
                {
                    curLongest += currChar;
                    prevChar = currChar;
                }
                else
                {
                    break;
                }
            }

            if (curLongest.Length > longest.Length)
            {
                longest = curLongest;
            }
            else if (curLongest.Length == longest.Length)
            {
                for (int j = 0; j < curLongest.Length; j++)
                {
                    if (curLongest[j] < longest[j])
                    {
                        longest = curLongest;
                    }
                    else if (curLongest[j] > longest[j])
                    {
                        curLongest = longest;
                    }
                }
            }
        }
        return longest;
    }
}