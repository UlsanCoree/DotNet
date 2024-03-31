using System;
using System.Collections.Generic;

class FindModeValue
{
    static void Main()
    {
        int[] numbers = { 1, 3, 3, 3, 3, 5, 5, 5,5,5,5, 2, 2, 2, 2, 2, 7 };
        int mode = FindMode(numbers);

        Console.WriteLine($"최빈값: {mode}");
    }

    private static int FindMode(int[] numbers)
    {
        Dictionary<int, int> prequency = new Dictionary<int, int>();

        int maxCount = 0;
        int mode = numbers[0];

        foreach (var num in numbers)
        {
            if (prequency.ContainsKey(num))
            {
                prequency[num]++;
            }
            else
            {
                prequency[num] = 1;
            }

            if (prequency[num] > maxCount)
            {
                maxCount = prequency[num];
                mode = num;
            }
        }

        return mode;
    }
}