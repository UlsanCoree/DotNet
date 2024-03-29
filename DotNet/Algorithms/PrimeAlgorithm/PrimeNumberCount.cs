using System;

class PrimeNumberCount
{
    static void Main()
    {
        int count = 0;
        var number = 0;
        bool isPrime;

        Console.Write("숫자를 입력하세요: _\b");

        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= number; i++)
        {
            isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }               
            }

            if (isPrime)
            {
                count++;
                Console.Write($"{i}\t");
                if (count % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine($"\n {number} 의 소수의 개수는: {count}");
    }
}
