using System;

class TextBombardment
{
    private static void Main()
    {
        string word = Console.ReadLine();
        int lineWidth = int.Parse(Console.ReadLine());
        string[] columns = Console.ReadLine().Split(' ');
        int match = 0;

        foreach (var item in columns)
        {
            int bomb = int.Parse(item);
            for (int i = bomb; i < word.Length; i += lineWidth)
            {
                if (match > 0 && char.IsWhiteSpace(word[i]))
                {
                    break;
                }
                else if (char.IsWhiteSpace(word[i]))
                {
                    continue;
                }
                else
                {
                    word = word.Remove(i, 1).Insert(i, " ");
                    match++;
                }
            }

            match = 0;

        }
        Console.WriteLine(word);
    }
}