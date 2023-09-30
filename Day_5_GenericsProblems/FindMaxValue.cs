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

        public static void FindMaximumValue(float a, float b, float c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum float value is:{a}");
            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum float value is:{b}");
            }
            else if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
            {
                Console.WriteLine($"Maximum float value is:{c}");
            }
        }

        public static void FindMaximumValue(string a, string b, string c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum string is:{a}");
            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine($"Maximum string is:{b}");
            }
            else if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
            {
                Console.WriteLine($"Maximum string is:{c}");
            }
        }
    }
}
