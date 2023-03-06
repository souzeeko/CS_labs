using System;

namespace CS_labs.individual_1
{
    partial class Program
    {
        void Ind_1_task_3()
        {
            int size = 10;
            int[,] matrix = new int[size, size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }

            Console.WriteLine("matrix:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
            
            double result = 1;
            int count = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    result *= matrix[i, j];
                    count++;
                }
            }

            double geomAVG = Math.Pow(result, 1.0 / count);
            Console.WriteLine($"upside elements' geometric mean: {geomAVG}" );

            int min = int.MaxValue;
            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }
            
            int[] arr = new int[size * size - (minI * size + minJ + 1)];
            int pos = 0;

            for (int i = minI; i < size; i++)
            {
                int startJ = (i == minI) ? minJ + 1 : 0;
                for (int j = startJ; j < size; j++)
                {
                    arr[pos] = matrix[i, j];
                    pos++;
                }
            }

            Console.WriteLine("array: ");
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}