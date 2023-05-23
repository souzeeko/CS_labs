using System;

namespace CS_lab_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("input amount of people: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] data = new Employee[n];
            
            for (int i = 0; i < n; i++)
            {
                data[i] = new Employee();
                data[i].Read();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {i + 1} data: {data[i].Surname} {data[i].Name[0]}. {data[i].Age(data[i].DateOfBirth)}yo, {data[i].PublicGender}, salary per month: {data[i].TotalPayday()}");
            }
        }
    }
}