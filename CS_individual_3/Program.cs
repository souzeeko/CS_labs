using System;

namespace CS_individual_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector_individual a = new Vector_individual(new double[]{0, 3, 2, 3});
            Vector_individual b = Vector_individual.FillRandom(-10,10);

            Console.WriteLine("\narray a arg by index: " + a.IndexArg(1));
            Console.WriteLine("\narray a new arg by index: " + a.NewArg(1, 1).ToString());
            Console.WriteLine("\nrandom array: " + b.ToString());
            Console.WriteLine("\narray a index: " + a.ArgLineSearch(1) + " / array b index: " + b.ArgLineSearch(11));
            Console.WriteLine("\narray a is sorted: " + a.SortCheck());
            Console.WriteLine("\n array a index: " + a.ArgBinarySearch(1) + " / array b index: " + b.ArgBinarySearch(11));
            Console.WriteLine("\narray a moved left: " + a.MoveLeft());
            Console.WriteLine("\narray a negative: " + a.NegativeArgsAmount(0));
        }
    }
}