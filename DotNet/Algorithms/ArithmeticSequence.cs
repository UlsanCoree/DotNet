// 1~20 까지 홀수의 합
using System;

class ArithmeticSequence
{
    static void Main()
    {
        // [1] Input
        int sum = 0;

        // [2] Process
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }
        }

        // [3] Output
        Console.WriteLine($"1부터 20까지 홀수의 합은: {sum}");
    }
}
