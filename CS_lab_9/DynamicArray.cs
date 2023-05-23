using System;

namespace CS_lab_9
{
    internal class DynamicArray
    {
        private int[] array;
        private int capacity;
        public int size { get; private set; }

        public DynamicArray(int capacity = 4)
        {
            this.capacity = capacity;
            array = new int[capacity];
            size = 0;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Add(int item)
        {
            if (size == capacity)
            {
                Resize();
            }

            array[size++] = item;
        }

        public void Remove()
        {
            if (size > 0)
            {
                array[--size] = 0;
            }

        }

        public void InsertIndex(int index, int newValue)
        {
            if (size == capacity)
            {
                Resize();
            }

            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = newValue;
            size++;
        }

        public void RemoveIndex(int index)
        {
            if (index >= 0 && index < size)
            {
                for (int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[--size] = 0;
            }
        }

        public void RemoveValue(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    RemoveIndex(i);
                    i--;
                }
            }
        }

        public int FindMaxIndex()
        {
            int maxIndex = 0;

            for (int i = 1; i < size; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public bool ArrayIsFull()
        {
            return size == capacity;
        }

        public int CountOfElement()
        {
            return size;
        }

        private void Resize()
        {
            capacity *= 2;
            int[] newArray = new int[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
