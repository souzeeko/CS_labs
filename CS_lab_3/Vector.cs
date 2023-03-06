using System;
using System.Linq;

namespace CS_lab_3
{
    public class Vector
    {
        private double[] array { get; set; }
        private int n { get; set; }

        public Vector() {}

        public Vector(double[] array)
        {
            this.array = array;
            this.n = array.Length;
        }

        public Vector(int n)
        {
            array = new double[n];
        }

        public int Size()
        {
            return array.Length;
        }

        public Vector(Vector copy)
        {
            array = (double[])copy.array.Clone();
        }
        
        public static Vector Read()
        {
            Console.Write("input array length: ");
            int n = Int32.Parse(Console.ReadLine());
            Vector array = new Vector(n);
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

        public Vector PositiveArgumentsOnly()
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
            return new Vector(positive);
        }
        
        public static Vector operator +(Vector a, Vector b)
        {
            if (a.Size() != b.Size())
            {
                throw new ArgumentException("Vectors must be of same size.");
            }

            Vector sum = new Vector(a.Size());

            for (int i = 0; i < a.Size(); i++)
            {
                sum.array[i] = a.array[i] + b.array[i];
            }
            return new Vector(sum);
        }
        
        public static double operator *(Vector a, Vector b)
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
        
        public static bool operator ==(Vector a, Vector b)
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

        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }
    }
}