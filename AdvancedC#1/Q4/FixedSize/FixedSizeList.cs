using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Q4.FixedSize
{

    internal class FixedSizeList<T>
    {
        public FixedSizeList(int capacity)
        {
            if (capacity < 0)
            {
                Console.WriteLine("Capacity should be positive");
            }
            Capacity = capacity;

            list = new T[Capacity];
            index = 0;
        }


        public int Capacity { get; set; }
        private T[]list;
        private int index;


        public void Add(T item) { 
        
            if (index > list.Length)
            {
                throw new IndexOutOfRangeException("List is full");
            }
            list[index] = item;
            index++;
        }

        public T Get(int x) {

            if (x < 0 || x > index)
            {
                throw new IndexOutOfRangeException("Invalid index. Index is out of range.");
            }
            return list[index];
        }

    }
}
