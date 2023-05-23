using System;

namespace CS_lab_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray numbers = new DynamicArray();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(40);
            numbers.Add(40);

            Console.WriteLine("Number of elements: " + numbers.CountOfElement());

            Console.Write("Array elements: ");
            numbers.Print();

            Console.WriteLine();

            Console.WriteLine("Remove last element: \t");
            numbers.Remove();
            numbers.Print();

            Console.WriteLine();

            Console.WriteLine("Inserting by index: \t");
            numbers.InsertIndex(2, 25);
            numbers.Print();

            Console.WriteLine();

            Console.WriteLine("Removing value: \t");
            numbers.RemoveValue(40);
            numbers.Print();

            Console.WriteLine();

            int maxIndex = numbers.FindMaxIndex();
            Console.WriteLine("Max element index: " + maxIndex);
        }
    }
}