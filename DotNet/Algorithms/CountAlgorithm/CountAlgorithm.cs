// [?] 1부터 1000까지의 정수 중 13의 배수의 개수
using System;
using System.Linq;

class CountAlgorithm
{
    static void Main()
    {
        // [1] input
        var numbers = Enumerable.Range(1, 1000).ToArray();
        int count = 0;

        // [2] process
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 13 == 0)
            {
                count++;
            }
        }

        // [3] output
        Console.WriteLine($"1부터 1000까지의 정수 중 13의 배수의 개수: {count}");
    }
}
