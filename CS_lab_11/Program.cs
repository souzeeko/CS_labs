using System;

namespace CS_lab_11
{
    internal class Program
    {
        static void Swap<T>(T[] a,int i1, int i2)
        {
            (a[i1], a[i2]) = (a[i2], a[i1]);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("\n[task 1a]\n");
            
            int[] a = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ", a));
            string[] b = { "red", "white", "black", "green" };
            Swap(a, 2, a.Length - 1);
            Console.WriteLine(string.Join(" ", a) + "\n");
            Array.ForEach(b, elem => Console.Write(elem + " "));
            Swap(b, 0, b.Length - 1);
            
            Console.Write("\n");
            
            Array.ForEach(b, elem => Console.Write(elem + " "));
            
            Console.WriteLine("\n\n[task 1b]\n"); 
            
            Console.Write("input amount of people: ");
            int n = int.Parse(Console.ReadLine());
            Person[] data = new Person[n];
            
            for (int i = 0; i < n; i++)
            {
                data[i] = new Person();
                data[i].Read();
            }
            
            Console.Write("\n");
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Person {i + 1} data: {data[i].Surname} {data[i].Name[0]}. {data[i].Age(data[i].DateOfBirth)}yo, {data[i].PublicGender}");
            }
            
            Swap(data, 0, data.Length - 1);
            
            Console.Write("\n");
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Person {i + 1} data: {data[i].Surname} {data[i].Name[0]}. {data[i].Age(data[i].DateOfBirth)}yo, {data[i].PublicGender}");
            }
        }
    }
}