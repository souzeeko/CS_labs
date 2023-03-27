using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace CS_lab_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n[task 1a]\n");
            
            
            
            Regex format_1a = new Regex(@"abcd(2023)1{7}0\1");
            Console.Write("input string: ");
            string input_1a = Console.ReadLine();
            
            if (format_1a.IsMatch(input_1a))
            {
                Regex newFormat = new Regex(@"2023");
                string result_1a = newFormat.Replace(input_1a, " happy new year ");
                Console.WriteLine($"new string: {result_1a}");
            }

            else
            {
                Console.WriteLine("incorrect format");
            }

            

            Console.WriteLine("\n[task 1b]\n");
            
            

            Console.Write("input string: ");
            string input_1b = Console.ReadLine();
            List<int> numbers_1b = new List<int>();
            int currentNumber = 0;

            foreach (char currentChar in input_1b)
            {
                if (Char.IsDigit(currentChar))
                {
                    currentNumber = currentNumber * 10 + int.Parse(currentChar.ToString());
                }
                
                else if (currentNumber != 0) 
                {
                    numbers_1b.Add(currentNumber);
                    currentNumber = 0; 
                }
            }

            if (currentNumber != 0)
            {
                numbers_1b.Add(currentNumber);
            }
            
            Console.Write("numbers: ");
            
            foreach (int number in numbers_1b)
            {
               Console.Write($"{number} ");
            }

            int sum = numbers_1b.Sum();
            Console.WriteLine($"\nsum: {sum}");
            int maxNumber = numbers_1b.Max();
            int maxIndex = numbers_1b.IndexOf(maxNumber);
            Console.WriteLine($"max: {maxNumber}, pos: {maxIndex + 1}");


            
            Console.WriteLine("\n[task 1c]\n");
            
            
            
            Console.Write("input string: ");
            string input_1c = Console.ReadLine();
            List<string> numbers_1c = new List<string>();
            MatchCollection isMatch_1c = Regex.Matches(input_1c, @"[-+]?\d+[.,]\d+?");

            foreach (Match match in isMatch_1c)
            {
                numbers_1c.Add(match.Value);
            }

            foreach (string result_1c in numbers_1c)
            {
               Console.WriteLine($"numbers: {result_1c}");
            }

            string result_1c_2 = Regex.Replace(input_1c, @"[-+]?\d+[.,]\d+?", " number ");
            Console.WriteLine($"new string: {result_1c_2}");

            
            
            Console.WriteLine("\n[task 1d]\n");
            
            
            
            Console.Write("pathToFile: ");
            string input_1d = Console.ReadLine();
            MatchCollection isMatch_1d = Regex.Matches(input_1d, @"\\([\w\d\s]+)");
            Console.Write("folders: ");
            
            foreach (Match match in isMatch_1d)
            {
                Console.Write($"{match.Groups[1].Value} ");
            }



            Console.WriteLine("\n\n[task 2a]\n");

            
            
            string[] input_2a = new string[5];

            for (int i = 0; i < input_2a.Length; i++)
            {
                Console.Write($"input string {i + 1}: ");
                input_2a[i] = Console.ReadLine();
            }

            Regex format_2a = new Regex(@"cat.*cat");
            
            Console.Write("strings: ");
            foreach (string result in input_2a)
            {
               if (format_2a.IsMatch(result))
               {
                    Console.Write($"{result}, "); //все что успел
               }
            }
        }
    }
}