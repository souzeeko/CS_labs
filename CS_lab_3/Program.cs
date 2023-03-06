using System;

namespace CS_lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector a = new Vector(new double[]{-6, 3, -2, -1});
            Vector b = new Vector(new double[]{1, 6, -4, 0});
            Vector c =  Vector.Read();
            
            Console.WriteLine("\n|a| is " + a.Module());
            Console.WriteLine("|b| is " + b.Module());
            Console.WriteLine("|c| is " + c.Module());
            
            Console.WriteLine("\nmax arg a is " + a.MaxArgument());
            Console.WriteLine("max arg b is " + b.MaxArgument());
            Console.WriteLine("max arg c is " + c.MaxArgument());
            
            Console.WriteLine("\nindex with min arg a is " + a.MinIndexArgument());
            Console.WriteLine("index with min arg b is " + b.MinIndexArgument());
            Console.WriteLine("index with min arg c is " + c.MinIndexArgument());
            
            Console.WriteLine("\npositive args a are " + a.PositiveArgumentsOnly());
            Console.WriteLine("positive args b are " + b.PositiveArgumentsOnly());
            Console.WriteLine("positive args c are " + c.PositiveArgumentsOnly());
            
            Vector sum = a + b;
            Console.WriteLine("\na + b = " + sum);

            double mult = a * b;
            Console.WriteLine("\na * b = " + mult);

            Console.WriteLine("\na anb b are equal: " + (a == b));
            Console.WriteLine("a and c are equal: " + (a == c));
            Console.WriteLine("b and c are equal: " + (b == c));
            Console.WriteLine("a and a are equal: " + (a == a));
        }
    }
}