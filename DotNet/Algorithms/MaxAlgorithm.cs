using System;
using System.Linq;

class MaxAlgorithm
{
    static void Main()
    {
        int[] numbers = { -10, -20, -5, -6, -3, -1 , -200 ,150};

        int maxNum = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }

        Console.WriteLine($"최댓값 : {maxNum}");
    }
}