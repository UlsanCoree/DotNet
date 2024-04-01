using System;

class Average
{
    static void Main()
    {
        int[] numData = { 90, 88, 40, 75, 59, 98, 71 };
        int sum = 0;
        int count = 0;

        for (int i = 0; i < numData.Length; i++)
        {
                sum += numData[i];
                count++;
        }

        double average = (double)sum / count;

        Console.WriteLine($"평균은: {average}");
    }
}
