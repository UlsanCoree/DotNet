using System;
using System.Linq;

class NearAlgorithm
{
    static void Main()
    {
        int min = int.MaxValue;

        int[] numbers = { 10, 20, 30, 27, 17 };
        int target = 25;
        int nearNum = default;

        for (int i = 0; i < numbers.Length; i++)
        {
            int abs = Math.Abs(numbers[i] - target);
            if (abs < min)
            {
                min = abs;
                nearNum = numbers[i];
            }
        }

        var minimum = numbers.Min(m => Math.Abs(m - target));
        var closest = numbers.First(n => Math.Abs(n - target) == minimum);

        Console.WriteLine($"{target} 에 가장 가까운 수는 {closest}, 차이는{minimum}");
        Console.WriteLine($"{target} 에 가장 가까운 수는 {nearNum}, 차이는{min}");
    }
}