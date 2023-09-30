using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_GenericsProblems
{
    class FindMaxValue <T> where T : IComparable
    {
        public T value1, value2, value3;
        
        public FindMaxValue(T x, T y, T z) 
        {
            value1 = x; 
            value2 = y; 
            value3 = z;
        }
        public static T FindMaximumValue(T a, T b, T c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
            {
                return c;
            }
            else
            {
                return default;
            }
        }
        
        public void TestMaximum()
        {
            Console.WriteLine("Maximum value (Method called from TextMaximum Method) : " + FindMaximumValue(value1, value2, value3));
        }
    }
}
