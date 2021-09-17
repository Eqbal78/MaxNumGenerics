using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumGenerics
{
    public class MaxNum<T> where T : IComparable
    {
        // Instance variables
        public T a, b, c;

        // Constructor
        public MaxNum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        // Generic method to find maximum value
        public static T Max(T a, T b, T c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                return a;

            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        // Generic method to call maximum method
        public T MaxMethod()
        {
            T maxNumber = MaxNum<T>.Max(this.a, this.b, this.c);
            return maxNumber;
        }

    }
}
