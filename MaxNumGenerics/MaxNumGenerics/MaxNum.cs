using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumGenerics
{
    class MaxNum
    {
        public static T Max<T>(T a, T b, T c) where T : IComparable
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

    }
}
