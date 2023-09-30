using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_GenericsProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problems.");
            bool continueExecution = true;
            while(continueExecution)
            {
                Console.WriteLine("Please choose program to perform:");
                Console.WriteLine("1.Find maximum integer value with generic method\n2.Find maximum float value with generic method\n" +
                    "3.Find maximum string value with generic method");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter 3 integers.");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int z = Convert.ToInt32(Console.ReadLine());
                        FindMaxValue<int>.FindMaximumValue( x, y, z);
                        break;

                    case 2:
                        Console.WriteLine("Please enter 3 float values.");
                        float x1 = float.Parse(Console.ReadLine());
                        float y1 = float.Parse(Console.ReadLine());
                        float z1 = float.Parse(Console.ReadLine());
                        FindMaxValue<float>.FindMaximumValue(x1, y1, z1);
                        break;

                    case 3:
                        Console.WriteLine("Please enter 3 string values.");
                        string x2 = Console.ReadLine();
                        string y2 = Console.ReadLine();
                        string z2 = Console.ReadLine();
                        FindMaxValue<string>.FindMaximumValue(x2, y2, z2);
                        break;
                }
                Console.WriteLine("Do you want to continue.(yes/no)");
                string userInput = Console.ReadLine();  
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
}
