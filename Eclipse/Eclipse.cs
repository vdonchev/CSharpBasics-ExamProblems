using System;

class Eclipse
{
    static void Main()
    {
        //input
        int length = int.Parse(Console.ReadLine());

        //print the glasses
        int fill = length * 2 - 2;

        for (int i = 0; i < length; i++)
        {
            char glass = '/';
            char verticalFrame = '*';
            char spacer = ' ';

            if(i == 0 || i == length - 1)
            {
                glass = '*';
                verticalFrame = ' ';
            }
            if(i == length / 2)
            {
                spacer = '-';
            }
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string(verticalFrame, 1), new string(glass, fill), new string(spacer, length - 1));
        }
    }
}