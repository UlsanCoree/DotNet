using System;
using System.Collections.Generic;

class NearAll
{
    static void Main()
    {
        int[] data = { 10, 20, 30, 23, 27 };
        int target = 25;
        int min = int.MaxValue;

        List<int> nears = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i]-target) < min)
            {
                min = Math.Abs(data[i] - target);
            }
        }

        Console.WriteLine(min);

        for (int i = 0;i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) == min)
            {
                nears.Add(data[i]);
            }
        }

        foreach (var nearValue in nears)
        {
            Console.WriteLine(nearValue);
        }
    }
}
