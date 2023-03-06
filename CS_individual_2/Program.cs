using System;

namespace CS_individual_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[task 1]\n");
            Figure Prism_1 = new Figure();
            Figure Prism_2 = new Figure("Prism_2", 5, 2);
            
            Prism_1.Read();
            Console.WriteLine("[===== first figure data =====]");
            Prism_1.Print();
            Console.WriteLine("[=============================]");
            
            Prism_2.Name = "Prism_2";
            Prism_2.Height = 5;
            Prism_2.SideLength = 2;
            Console.WriteLine("[===== second figure data =====]");
            Prism_2.Print();
            Console.WriteLine("[==============================]");

            if (Prism_1.Volume() > Prism_2.Volume())
            {
                Console.WriteLine($"figure {Prism_1.Name} has the biggest volume value");
            }

            else if (Prism_1.Volume() < Prism_2.Volume())
            {
                Console.WriteLine($"figure {Prism_2.Name} has the biggest volume value");
            }

            else
            {
                Console.WriteLine("figures' volume values are equal");
            }

            double Square_1 = Prism_1.Square();
            double Square_2 = Prism_2.Square();

            if (Math.Abs(Square_1 - 100) > Math.Abs(Square_2 - 100))
            {
                Console.WriteLine($"{Prism_1.Name}'s square is closer to 100");
            }

            else if (Math.Abs(Square_1 - 100) < Math.Abs(Square_2 - 100))
            {
                Console.WriteLine($"{Prism_2.Name}'s square is closer to 100");
            }
            
            Console.WriteLine("\n[task 2]\n");
            Console.Write("input amount of figures: ");
            int n = int.Parse(Console.ReadLine());
            Figure[] Figures = new Figure[n];

            for (int i = 0; i < n; i++)
            {
                Figures[i] = new Figure();
                Figures[i].Read();
            }

            Console.WriteLine("\n[task 2a]\n");
            Figure WithLongestName = new Figure();
            int Length = 0;

            for (int i = 1; i < n; i++)
            {
                
                if (Figures[i].Name.Length > Figures[Length].Name.Length)
                {
                    Length = i;
                }

            }

            Figures[Length].Print();
            
            Console.WriteLine("\n[task 2b]\n");
            Figure x2Prism = new Figure();
            x2Prism.Name = "x2Prism";
            x2Prism.Height = Figures[Figures.Length - 1].Height * 2;
            x2Prism.SideLength = Figures[Figures.Length - 1].SideLength * 2;
            x2Prism.Print();
            Console.WriteLine($"{x2Prism.Name} height: {x2Prism.Height}");
            Console.WriteLine($"{x2Prism.Name} side length: {x2Prism.SideLength}");
            
            Console.WriteLine("\n[task 2c]\n");
            double SquareSum = 0;

            for (int i = 0; i < n; i++)
            {
                SquareSum += Figures[i].Square();
            }

            Console.WriteLine($"sum of all squares is {SquareSum}");

            Console.WriteLine("\n[task 2d]\n");
            int MinSquare = 0;

            for (int i = 0; i < n; i++)
            {
                if (Figures[i].Square() < Figures[MinSquare].Square())
                {
                    MinSquare = i;
                }
            }

            Console.WriteLine($" {Figures[MinSquare].Name = "MIN " + Figures[MinSquare].Name}");
            
            Console.WriteLine("\n[task 2e]\n");
            int Count = 0;

            for (int i = 0; i < n; i++)
            {
                if (Figures[i].Square() > 15)
                {
                    Count++;
                }
            }

            Console.WriteLine($"amount of figures with square > 15 is {Count}");
            
            Console.WriteLine("\n[task 2f]\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Figures[i].Volume()} ");
            }
            
            Console.WriteLine("\n\n[task 2g]\n");
            double VolumeSum = 0;

            for (int i = 0; i < n; i++)
            {
                VolumeSum += Figures[i].Volume();
            }

            Console.WriteLine($"sum of all volumes is {VolumeSum}");
        }
    }
}