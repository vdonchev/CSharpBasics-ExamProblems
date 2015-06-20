using System;

class ArrayMatcher
{
    static void Main()
    {
        // input
        string[] inputs = Console.ReadLine().Split('\\');

        string leftArray = SortMe(inputs[0]);
        string rightArray = SortMe(inputs[1]);
        string command = inputs[2];

        switch (command)
        {
            case "join":
                Console.WriteLine(Join(leftArray, rightArray));
                break;
            case "left exclude":
                Console.WriteLine(LeftExclude(leftArray, rightArray));
                break;
            case "right exclude":
                Console.WriteLine(RightExclude(leftArray, rightArray));
                break;
        }
    }

    private static string Join(string left, string right)
    {
        string output = string.Empty;
        for (int i = 0; i < left.Length; i++)
        {
            for (int j = 0; j < right.Length; j++)
            {
                if (left[i] == right[j])
                {
                    output += left[i];
                }
            }
        }

        return output;
    }

    private static string LeftExclude(string left, string right)
    {
        string output = string.Empty;
        for (int i = 0; i < right.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < left.Length; j++)
            {
                if (right[i] == left[j])
                {
                    found = true;
                }
            }
            if (found == false)
            {
                output += right[i];
            }
        }

        return output;
    }

    private static string RightExclude(string left, string right)
    {
        string output = string.Empty;
        for (int i = 0; i < left.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < right.Length; j++)
            {
                if (left[i] == right[j])
                {
                    found = true;
                }
            }
            if (found == false)
            {
                output += left[i];
            }
        }

        return output;
    }

    private static string SortMe(string array)
    {
        char[] a = array.ToCharArray();
        Array.Sort(a);
        return new string(a);
    }
}