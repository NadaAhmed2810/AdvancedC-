using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question2
{
    internal class Range<T> where T:struct, IComparable<T>,INumber<T>
    {
        public T  Min{ get; set; }
        public T Max{ get; set; }
        public Range(T min, T max)
        {
            if (min > max) min= default;
            Min = min;
            Max = max;
        }
        public bool IsInRange(T Value)
        {
            return Min.CompareTo(Value) <= 0 && Max.CompareTo(Value)>=0 ;
        }
        public T Length()
        {
            return Max - Min;
        }

    }
}
