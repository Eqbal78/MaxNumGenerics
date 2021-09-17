using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumGenerics
{
    public class MaxNum<T> where T : IComparable
    {
        // Empty Array
        public T[] value;

        //Parameter Constructor
        public MaxNum(T[] value)
        {
            this.value = value;
        }

        // Sorting the Value
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        //Generic method Comparing and find Max Value
        public T MaxValue(T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        // Generic method to call maxvalue method
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

    }
}
