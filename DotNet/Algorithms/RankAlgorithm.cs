using System;
using System.Linq;

class RankAlgorithm
{
    static void Main()
    {
        int[] scores = { 87, 94, 99, 79, 100, 71, 59, 92 };
        int[] rankings = Enumerable.Repeat(1, 8).ToArray();

        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1;
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[i] < scores[j])
                {
                    rankings[i]++;
                }
            }
        }

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"{scores[i],3}점: {rankings[i]}등");
        }
    }
}
