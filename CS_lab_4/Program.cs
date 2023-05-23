using System;

namespace CS_lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("input array's capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            DynamicArray array = new DynamicArray(capacity); array.Fill(1, 10);
            Console.Write("array filled with digits: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            array.AddToEnd(11);
            Console.Write("11 is added to end: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            array.RemoveFromEnd();
            Console.Write("last digit is removed: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            array.InsertByIndex(2, 3);
            Console.Write("3 is added by index 2: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            array.RemoveByIndex(2);
            Console.Write("digit is removed by index 2: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            array.RemoveByValue(3);
            Console.Write("value 3 is removed: ");
            
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            
            Console.WriteLine();

            int[] max = array.Max();
            Console.WriteLine($"max value is {max[1]}, its index is {max[0]}");
            Console.WriteLine($"array is full: {array.IsFull()}");
            Console.WriteLine($"elems amount: {array.Count()}");
        }
    }
}