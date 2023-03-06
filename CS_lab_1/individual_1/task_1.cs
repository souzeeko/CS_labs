using System;

namespace CS_labs.individual_1
{
    partial class Program
    {
        void Ind_1_task_1()
        {
            double Input()
            {
                Console.WriteLine("input x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                return x;

            }
            
            double FunctionCalculation(double x)
            {
                if (x < -4)
                {
                    return ((Math.Pow(x, 2) - 1 / x) / 3 * x) * ((x + 3) / 1 + x);
                }
                else if (x >= -4 || x < 6 * Math.PI)
                {
                    return Math.Pow(x - 5, 2) * Math.Pow(Math.Sin(2 * x), 2);
                }
                else
                {
                    return 11 * (2 / 3);
                }
            }
            
            int n = 8;
            double[] x = new double[n];
            double[] y = new double[n];
            int count = 0;
            double minY = double.MaxValue;
            double dotX = 0;
            double dotY = 0;
            
            for (int i = 0;
                 i < n;
                 i++)
            {
                x[i] = Input();
                y[i] = FunctionCalculation(x[i]);
                bool result = false;
                if (x[i] >= 0 && y[i] <= 0)
                {
                    result = y[i] >= -4 + x[i];
                }
                else if (x[i] < 0 && y[i] < 0)
                {
                    result = x[i] * x[i] + y[i] * y[i] <= 16;
                }
                else if (x[i] <= -2 && y[i] > 0)
                {
                    result = x[i] * x[i] + y[i] * y[i] <= 16;
                }

                if (result)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"*not in area* distance from (0, 0) is {Math.Sqrt(x[i] * x[i] + y[i] * y[i])}\n");
                    if (x[i] > 0 && y[i] < 0)
                    {
                        if (Math.Abs(y[i]) < minY)
                        {
                            minY = y[i];
                            dotX = x[i];
                            dotY = y[i];
                        }
                    }
                }
            }
            
            Console.WriteLine($"amount of dots in area is {count}\n");
            if (minY != double.MaxValue)
            {
                Console.WriteLine($"closest to OY dot from *not in area* dots is ({dotX}, {dotY})\n");
            }
        }
    }
}