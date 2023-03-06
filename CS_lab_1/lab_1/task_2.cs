using System;

namespace CS_labs.lab_1
{
    partial class Program
    {
        double charka(double chark)
        {
            return chark * 0.123;
        }

        double shkalik(double shkal)
        {
            return shkal * 0.06;
        }

        double max(double x, double y, double z)
        {
            double max1;
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > z)
            {
                return y;
            }
            else
            {
                return z;
            }
        }

        void Lab_1_task_2()
        {

            string first, second, third;
            Console.Write("input first name: ");
            first = Console.ReadLine();
            Console.Write("input second name: ");
            second = Console.ReadLine();
            Console.Write("input third name: ");
            third = Console.ReadLine();
            Console.Write("input charka amount first guy did: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("input shkalik amount second guy did: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("input charka amount third guy did: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write("input skalik amount third guy did: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"first did {charka(x)} ltr");
            Console.WriteLine($"second did {shkalik(y)} ltr");
            Console.WriteLine($"third did {charka(z) + shkalik(w)} ltr");
            if (1.0 < charka(x) || charka(x) < 0.5)
            {
                Console.WriteLine("first did less than 0.5 or more than 1");
            }

            if (1.0 < shkalik(y) || shkalik(y) < 0.5)
            {
                Console.WriteLine("second guy did less than 0.5 or more than 1");
            }
            
            if (1.0 < shkalik(w) + charka(z) || shkalik(w) + charka(z) < 0.5)
            {
                Console.WriteLine("third guy did less than 0.5 or more than 1");
            }
            Console.WriteLine($"drank together {shkalik(w) + charka(z) + shkalik(y) + charka(x)} ltr");
            Console.WriteLine($"max drank did {max(shkalik(w) + charka(z), shkalik(y), charka(x))} ltr");
        }
    }
}