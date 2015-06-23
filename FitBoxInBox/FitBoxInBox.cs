using System;

class FitBoxInBox
{
    static void Main()
    {
        int[] box1 = new int[3];

        int a = 10;
        int b = 12;
        int c = 11;

        int x = 3;
        int y = 5;
        int z = 2;

        for (int i = 0; i < 3; i++)
            {
                int one = array[i];
                for (int j = 0; j < 3; j++)
                {
                    if (j != i)
                    {
                        int two = array[j];

                        for (int k = 0; k < 3; k++)
                        {
                            if (k != i && k != j)
                            {
                                int three = array[k];
                                if (x < one && y < two && z < three)
                                {
                                    Console.WriteLine("({3}, {4}, {5}) < ({0}, {1}, {2})", one, two, three, x, y, z);
                                }
                            }
                        }
                    }
                }
            }
        }


        
    }
}