using System;

class SortAlgorithm
{
    static void Main()
    {
        int[] data = { 3, 2, 1, 5, 4 };

        for (int i = 0; i < data.Length - 1; i++)
        {
            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[i] > data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }

        for (int i = 0; i < data.Length; i++)
        {
            Console.Write($"{data[i]}\t");
        }
        Console.WriteLine();
    }
}
