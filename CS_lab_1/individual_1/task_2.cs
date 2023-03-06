using System;

namespace CS_labs.individual_1
{
    partial class Program
    {
        void TriangleData(double triangle[3])
        {
            Console.Write("input triangle data: ");
            
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"input side {i + 1}: ");
                triangle[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            Console.Write("input angle: ");
            triangle[2] = Convert.ToDouble(Console.ReadLine());
        }
        
        double AreaCalculation(double a, double b, double angle)
        {
            double rad = angle * Math.PI / 180;
            return a * b * Math.Sin(rad) * 0.5;
        }

        void Ind_1_task_2(string[] args)
        {   
            double maxArea = Double.MinValue;
            double sumArea = 0;
            int count = 0;
            
            for (int i = 0; i < 4; i++)
            {
                double[] triangle = new double[3];
                
                
                
                double area;
                area = AreaCalculation(triangle[0], triangle[1], triangle[2]);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (area >= 10 && area <= 20)
                {
                    count++;
                }

                if (i < 3)
                {
                    sumArea += area;
                }
            }
            
            Console.WriteLine($"max area is {maxArea}");
            Console.WriteLine($"sum of firs three areas is {sumArea}");
            Console.WriteLine($"amount of areas from [10, 20] interval is {count}");
        }
    }
}