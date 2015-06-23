using System;

class InsideTheBuilding
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y > size * 4 || y < 0)
            {
                Console.WriteLine("outside");
            }
            else if (y <= size)
            {
                Console.WriteLine((x >= 0 && x <= size * 3) ? "inside" : "outside");
            }
            else
            {
                Console.WriteLine((x >= size && x <= size * 2) ? "inside" : "outside");
            }
        }
    }
}