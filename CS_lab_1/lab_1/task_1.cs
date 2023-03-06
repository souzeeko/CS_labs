using System;

namespace CS_labs.lab_1
{
    partial class Program
    {
        void Lab_1_task_1()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int vozr = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Привет {name} через год тебе будет {vozr + 1} лет");
        }
    }
}