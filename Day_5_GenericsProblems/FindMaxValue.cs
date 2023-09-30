using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Day_5_GenericsProblems
{
    class FindMaxValue <T> where T : IComparable<T>
    {
        public T[] values;
        
        public FindMaxValue(params T[] values) 
        {
            this.values = values; 
        }
        public T FindMaximumValue()
        {
            if (values.Length == 0)
            {
                Console.WriteLine("No value provided");
                return default(T);
            }

            T max = values[0];
            foreach (T value in values)
            {
                if (value.CompareTo(max) > 0)
                {
                    max = value;
                }
            }

            return max;
        }

        
        public void TestMaximum()
        {
            T max = FindMaximumValue();
            PrintMax(max);  
        }

        private void PrintMax(T max)
        {
            if (!max.Equals(default(T)))
            {
                Console.WriteLine("The maximum vlue is :" + max);
            }
        }
        
    }
}
