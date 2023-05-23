using System;
using System.Linq;
using System.Collections.Generic;


namespace CS_lab_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[task 1]\n");
            
            Console.Write("input names: ");
            string inputString1 = Console.ReadLine();
            if (inputString1 != null)
            {
                string[] names = inputString1.Split(' ');
                List<string> resultString1 = new List<string>();

                foreach (string name in names)
                {
                    if (string.Compare(name, "Marie") < 0)
                    {
                        resultString1.Add(name);
                    }
                }

                resultString1.Sort();

                foreach (string name in resultString1)
                {
                    Console.WriteLine(name);
                }
            }

            Console.WriteLine("\n[task 2]\n");
            
            Console.Write("input string: ");
            string inputString2 = Console.ReadLine();
            string[] stroke = inputString2.Split(' ');
            List<string> resultString2 = new List<string>();

            foreach (string word in stroke)
            {
                if (word.Length == 4)
                {
                    resultString2.Append("love_Is");
                }
                
                else
                {
                    resultString2.Append(word + " ");
                }
            }

            foreach (string word in resultString2)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n[task 3]\n");
            
            Console.Write("input string: ");
            string inputString3 = Console.ReadLine();
            Console.Write("input gap: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = n; i < inputString3.Length; i += (n + 1))
            {
                inputString3 = inputString3.Insert(i, ":)");
            }
            
            Console.WriteLine(inputString3);

            Console.WriteLine("\n[task 4]\n");

            Console.Write("input string: ");
            string inputString4 = Console.ReadLine();
            string[] words4 = inputString4.Split(' ');

            string longest = words4[0];
            string shortest = words4[0];

            foreach (string word in words4)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
                
                if (word.Length < shortest.Length)
                {
                    shortest = word;
                }
            }

            string result = $"{longest},{shortest}\n";

            for (int i = 0; i < longest.Length; i++)
            {
                result += longest + ",";
            }
            
            for (int i = 0; i < shortest.Length; i++)
            {
                result += shortest;
                if (i < shortest.Length - 1)
                {
                    result += ",";
                }
            }
            
            Console.WriteLine(result);

            Console.WriteLine("\n[task 5]\n");

            Console.Write("input string: ");
            string inputString5 = Console.ReadLine();
            string[] words5 = inputString5.Split(' ');
            List<string> resultString5 = new List<string>();

            foreach (string word in words5)
            {
                if (!resultString5.Contains(word))
                {
                    resultString5.Add(word);
                }
            }   

            string result5 = "";
            
            foreach (string word in resultString5)
            {
                result5 += word + " ";
            }

            Console.WriteLine(result5);
        }
    }
}