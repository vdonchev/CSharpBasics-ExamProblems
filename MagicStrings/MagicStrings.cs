using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());

        Dictionary<char, int> collection = new Dictionary<char, int>();
        collection.Add('k', 1);
        collection.Add('n', 4);
        collection.Add('p', 5);
        collection.Add('s', 3);

        bool found = false;

        foreach (var pair1 in collection)
        {
            foreach (var pair2 in collection)
            {
                foreach (var pair3 in collection)
                {
                    foreach (var pair4 in collection)
                    {
                        int sum1 = pair1.Value + pair2.Value + pair3.Value + pair4.Value;
                        string string1 = "" + pair1.Key + pair2.Key + pair3.Key + pair4.Key;

                        foreach (var pair5 in collection)
                        {
                            foreach (var pair6 in collection)
                            {
                                foreach (var pair7 in collection)
                                {
                                    foreach (var pair8 in collection)
                                    {
                                        int sum2 = pair5.Value + pair6.Value + pair7.Value + pair8.Value;
                                        string string2 = "" + pair5.Key + pair6.Key + pair7.Key + pair8.Key;

                                        if (Math.Abs(sum1 - sum2) == diff)
                                        {
                                            found = true;
                                            Console.WriteLine(string1 + string2);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}