using System;
using System.Linq;

class MaxAlgorithm
{
    static void Main()
    {
        int max = int.MinValue;

        int[] numbers = { -10, -20, -5, -6, -3, -1 , -200 ,150};


        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine($"최댓값 : {max}");
    }
}