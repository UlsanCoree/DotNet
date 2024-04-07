using System;
using System.Linq;

class MinAlgorithm
{
    static void Main()
    {
        int min = int.MaxValue;

        int[] numbers = {  10, 90 , 40, 20, 4, 3, 2, 1};

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"최솟값: {min}");
    }
}
