using System;

class FriendBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());

        uint friends = 0;
        uint singles = 0;

        for (int i = 31; i >= 0; i--)
        {
            uint currBit = num >> i & 1;

            uint leftBit = 0;
            uint rightBit = 0;

            bool leftPos = (i + 1 <= 31);
            if (leftPos)
            {
                leftBit = num >> i + 1 & 1;
            }

            bool rightPos = (i - 1 >= 0);
            if (rightPos)
            {
                rightBit = num >> i - 1 & 1;
            }

            if (leftPos && leftBit == currBit || rightPos && rightBit == currBit)
            {
                friends = friends << 1 | currBit;
            }
            else
            {
                singles = singles << 1 | currBit;
            }
        }

        // debug
        //Console.WriteLine(Convert.ToString(friends, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(singles, 2).PadLeft(32, '0'));
        Console.WriteLine(friends);
        Console.WriteLine(singles);
    }
}