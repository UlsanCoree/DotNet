using System;

class AverageCount
{
    static void Main()
    {
        int[] scores = { 100, 90, 80, 70, 60 };
        int sum = 0;
        double average = 0;
        int aveOverCount = 0;

        foreach (var score in scores)
        {
            sum += score;
        }

        if (sum != 0 && scores.Length != 0)
            average = (double)sum / scores.Length;

        foreach (var score in scores)
        {
            if (score >= average)
                aveOverCount++;
        }

        Console.WriteLine($"전체 학생의 평균 {average} 이상인 학생 수: {aveOverCount}");
    }
}