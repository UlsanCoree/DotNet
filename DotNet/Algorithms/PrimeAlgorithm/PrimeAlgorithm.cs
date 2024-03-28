using System;

class PrimeAlgorithm
{
    /*
    #region FirstTry
    static void Main()
    {
        int n = 101;
        Console.WriteLine(isPrime(n)? $"{n}은 소수입니다.": $"{n}은 소수가 아닙니다.");
    }

    static bool isPrime(int n)
    {
        if (n == 1) return false;
        if (n == 2) return true;

        var limit = Math.Sqrt(n);
        for (int i = 2; i < limit; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    #endregion
    */

    static void Main()
    {
        int number;
        Console.Write("숫자를 입력하세요: _\b");
        number = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        do
        {
            i++;
            Console.WriteLine($"{number} % {i} = {number % i}");
        } while (number % i != 0);

        if (number == i) Console.WriteLine($"{number}은 소수입니다.");
        else Console.WriteLine($"{number}은 소수가 아닙니다.");
    }
}