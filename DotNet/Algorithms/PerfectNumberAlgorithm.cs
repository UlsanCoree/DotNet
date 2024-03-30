// 1부터 10,000 까지 완전수와 개수 구하기

using System;

class PerfectNumberAlgorithm
{
    static void Main()
    {
        int count = 0;      //완전수 개수
        int sum = 0;        //약수의 합
        int max = 0;        //최대 약수

        for (int i = 1; i <= 10000; i++)
        {
            sum = 0;
            max = i / 2;

            for (int j = 1; j <= max; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }

            if (i == sum)
            {
                Console.WriteLine($"완전수 : {i}");
                count++;
            }
        }

        Console.WriteLine("완전수 개수{0}", count);
    }
}
