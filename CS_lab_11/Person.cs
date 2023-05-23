using System;
using System.Runtime.InteropServices;

namespace CS_lab_11
{
    public class Person
    {
        public string Surname { get; protected set; }
        public string Name { get; protected set; }
        public DateTime DateOfBirth { get; protected set; }
        protected char Gender;

        public char PublicGender
        {
            get => Gender;
            private set
            {
                if (value == 'M' || value == 'F') Gender = value;
            }
        }

        public int Age(DateTime date)
        {
            int Age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Day < date.Day)
            {
                if (DateTime.Now.Month < date.Month)
                {
                    Age--;
                }
            }

            return Age;
        }

        public virtual void Read()
        {
            Console.Write("input name: ");
            Name = Console.ReadLine();
            Console.Write("input surname: ");
            Surname = Console.ReadLine();
            Console.Write("input date of birth in format year-month-day: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("input gender in format M/F: ");
            PublicGender = char.Parse(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"person's name: {Name}, surname: {Surname}, gender: {PublicGender}, age: {Age(DateOfBirth)}");
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + DateOfBirth + " " + Gender + " ";
        }

        public Person() {}
    }
}