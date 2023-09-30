using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_GenericsProblems
{
    class FindMaxValue
    {
        public static void FindMaximumValue(int a, int b, int c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum integer is:{a}");
            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum integer is:{b}");
            }
            else if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
            {
                Console.WriteLine($"Maximum integer is:{c}");
            }
        }
    }
}
