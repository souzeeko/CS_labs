using System;
using System.Linq;

namespace CS_individual_3
{
    public class Vector_individual
    {
        private double[] array { get; set; }
        private int n { get; set; }

        public Vector_individual() {}

        public Vector_individual(double[] array)
        {
            this.array = array;
            this.n = array.Length;
        }

        public Vector_individual(int n)
        {
            array = new double[n];
        }

        public int Size()
        {
            return array.Length;
        }

        public Vector_individual(Vector_individual copy)
        {
            array = (double[])copy.array.Clone();
        }
        
        public static Vector_individual Read()
        {
            Console.Write("input array length: ");
            int n = Int32.Parse(Console.ReadLine());
            Vector_individual array = new Vector_individual(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"input argument {i + 1}: ");
                array.array[i] = double.Parse(Console.ReadLine());
            }

            return array;
        }

        public override string ToString()
        {
            return "[" + $"{string.Join(", ", array)}" + "]";
        }

        public double Module()
        {
            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += Math.Pow(array[i], 2);
            }

            return Math.Sqrt(sum);
        }

        public double MaxArgument()
        {
            return array.Max();
        }

        public int MinIndexArgument()
        {
            int index = 0;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        public Vector_individual PositiveArgumentsOnly()
        {
            int length = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    length++;
                }
            }

            double[] positive = new double[length];
            int index= 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {

                    positive[index] = array[i];
                    index++;
                }
            }
            return new Vector_individual(positive);
        }
        
        public static Vector_individual operator +(Vector_individual a, Vector_individual b)
        {
            if (a.Size() != b.Size())
            {
                throw new ArgumentException("Vectors must be of same size.");
            }

            Vector_individual sum = new Vector_individual(a.Size());

            for (int i = 0; i < a.Size(); i++)
            {
                sum.array[i] = a.array[i] + b.array[i];
            }
            return new Vector_individual(sum);
        }
        
        public static double operator *(Vector_individual a, Vector_individual b)
        {
            if (a.Size() != b.Size())
            {
                throw new ArgumentException("Vectors must be of same size.");
            }

            double mult = 0;

            for (int i = 0; i < a.Size(); i++)
            {
                mult += a.array[i] * b.array[i];
            }
            return mult;
        }
        
        public static bool operator ==(Vector_individual a, Vector_individual b)
        {
            if (a.Size() != b.Size())
            {
                return false;
            }

            for (int i = 0; i < a.Size(); i++)
            {
                if (a.array[i] != b.array[i])
                {
                    return false;
                }
            }
            
            return true;
        }

        public static bool operator !=(Vector_individual a, Vector_individual b)
        {
            return !(a == b);
        }
        
        public double IndexArg(int i)
        {
            return array[i];
        }

        public double[] NewArg(int i, double value)
        {
            array[i] = value;
            return array;
        }

        public static Vector_individual FillRandom(int a, int b)
        {
            Random random = new Random();
            Console.Write("input random array length: ");
            int n = Int32.Parse(Console.ReadLine());
            Vector_individual array = new Vector_individual(n);
            
            for (int i = 0; i < n; i++)
            {
                array.array[i] = random.Next(a, b);
            }

            return array;
        }

        public string ArgLineSearch(double value)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i.ToString();
                }
            }

            return "argument not found";
        }

        public bool SortCheck()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public string ArgBinarySearch(double value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                if (left == value)
                {
                    return left.ToString();
                }
                else if (right == value)
                {
                    return right.ToString();
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return "argument not found";
        }
        
        public double[] MoveLeft()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length -1] = 0;
            
            return array;
        }

        public bool NegativeArgsAmount(int amount)
        {
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            if (count <= amount)
            {
                return true;
            }

            return false;
        }
    }
}