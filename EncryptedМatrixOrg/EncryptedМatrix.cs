using System;

class EncryptedМatrix
{
    static void Main()
    {
        string msg = Console.ReadLine();
        string direction = Console.ReadLine();

        int[] nums = new int[msg.Length + 2];
        nums[0] = 0;
        for (int i = 1; i <= msg.Length; i++)
        {
            nums[i] = msg[i - 1] % 10;
        }
        nums[msg.Length + 1] = 0;

        string encrypted = string.Empty;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            int curNum = nums[i];
            if (curNum % 2 == 0)
            {
                encrypted += curNum * curNum;
            }
            else
            {
                encrypted += Sum(curNum, nums[i - 1], nums[i + 1]);
            }
        }

        // build the matrix
        int[,] matrix = new int[encrypted.Length, encrypted.Length];
        for (int row = 0; row < encrypted.Length; row++)
        {
            for (int col = 0; col < encrypted.Length; col++)
            {
                matrix[row, col] = 0;
            }
        }

        if (direction == "/")
        {
            int col = 0;
            for (int row = encrypted.Length - 1; row >= 0; row--)
            {
                matrix[row, col] = int.Parse(encrypted[col].ToString());
                col++;
            }
        }
        else
        {
            int col = 0;
            for (int row = 0; row < encrypted.Length; row++)
            {
                matrix[row, col] = int.Parse(encrypted[col].ToString());
                col++;
            } 
        }

        // print
        for (int row = 0; row < encrypted.Length; row++)
        {
            for (int col = 0; col < encrypted.Length; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static int Sum(int one, int two, int three)
    {
        int sum = one + two + three;
        return sum;
    }
}