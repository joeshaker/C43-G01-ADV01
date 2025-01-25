using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Q1.Range
{
    internal class Range<T>where T:IComparable<T>,INumber<T>
    {
        public Range(T? maximum, T? minimum)
        {
            Maximum = maximum;
            Minimum = minimum;
        }

        public T? Maximum { get; set; }
        public T? Minimum { get; set; }

        public bool IsRange(T value)
        {
            return value.CompareTo(Minimum)>=0 && value.CompareTo(Maximum)<=0;
        }

        public void Length()
        {
            if (Minimum is not null && Maximum is not null)
            {
                Console.WriteLine($"{Maximum - Minimum}");
            }
            else { Console.WriteLine("Max or Min Can't be null"); }
            
        }
        public T[] Reverse(T[] value) {
            int start = 0;
            int end= value.Length-1;

            while (start < end) { 
            T arr= value[start];
            value[start] = value[end];
            value[end] = arr;
            start++;
            end--;
            }

            return value;

        }


    }
}
