using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab_4
{
    public class DynamicArray
    {
       private int[] array;    
        private int size;       
        private int capacity;  
        
        public DynamicArray(int capacity)
        {
            this.array = new int[capacity];
            this.size = 0;
            this.capacity = capacity;
        }
        
        public void Fill(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                AddToEnd(i);
            }
        }
        
        public int GetByIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }
        
        public void SetByIndex(int index, int value)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        }
        
        public void AddToEnd(int element)
        {
            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }
            array[size] = element;
            size++;
        }
        
        public void RemoveFromEnd()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            
            size--;
        }
        
        public void InsertByIndex(int index, int element)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }

            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }

            for (int i = size - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            
            array[index] = element;
            size++;
        }
        
        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            
            size--;
        }

        public void RemoveByValue(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    RemoveByIndex(i);
                }
            }
        }

        public int[] Max()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            
            int maxIndex = 0;
            
            for (int i = 1; i < size; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            return new int[] { maxIndex, array[maxIndex] };
        }
        
        public bool IsFull()
        {
            return size == capacity;
        }
        
        public int Count()
        {
            return size;
        } 
    }
}