using System;

class Car
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int widith = size * 3;
        int halfHeigth = size / 2;
        int wheelHeigth = (size / 2) - 1;
        int wheelsWidth = (size + 2) / 2;
        int betweenWheels = size - 2;
        int beforeWheels = size / 2;

        int outter = size - 1;
        int inner = size;

        Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        for (int i = 0; i < halfHeigth - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string('.', inner));
            outter--;
            inner += 2;
        }

        Console.WriteLine("{0}*{1}*{0}", new string('*', outter), new string('.', inner));
        for (int i = 0; i < halfHeigth - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', widith - 2));
        }

        Console.WriteLine("{0}", new string('*', widith));

        for (int i = 0; i < wheelHeigth - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', beforeWheels), new string('.', wheelsWidth - 2), new string('.', betweenWheels));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', beforeWheels), new string('*', wheelsWidth), new string('.', betweenWheels));
    }
}