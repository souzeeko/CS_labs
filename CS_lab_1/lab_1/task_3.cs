using System;

namespace CS_labs.lab_1
{
    partial class Program
    {
        void Lab_1_task_3()
        {
            Console.WriteLine("input your date of birth: ");
            DateTime data1 = Convert.ToDateTime(Console.ReadLine());
            DateTime data2 = DateTime.Now;

            int age;
            if (data2.Month < data1.Month)
            {
                age = data2.Year - data1.Year - 1;
            }

            else if (data2.Month > data1.Month)
            {
                age = data2.Year - data1.Year;
            }

            else
            {
                if (data2.Day >= data1.Day)
                {
                    age = data2.Year - data1.Year;
                }
                else
                {
                    age = data2.Year - data1.Year - 1;
                }
            }

            if (age % 100 >= 11 && age % 100 <= 20)
            {
                Console.WriteLine($"Вам {age} лет");
            }
            else if (age % 10 == 1)
            {
                Console.WriteLine($"Вам {age} год");
            }
            else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
            {
                Console.WriteLine($"Вам {age} года");
            }
            else
            {
                Console.WriteLine($"Вам {age} лет");
            }
        }
    }
}