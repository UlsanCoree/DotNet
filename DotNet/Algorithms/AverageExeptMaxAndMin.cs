using System;
using System.Linq;

class AverageExeptMaxAndMin
{
    static void Main()
    {
        int[] scores = { 10, 20, 30, 40, 50 };

        int count = 0;
        int sum = 0;
        int min = scores.Min();
        int max = scores.Max();

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] != min && scores[i] != max)
            {
                sum += scores[i];
                count++;
            }
        }
        var average = count > 0 ? (double)sum / count : 0;

        Console.WriteLine($"{average}");
    }
}
