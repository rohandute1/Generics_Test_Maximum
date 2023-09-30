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
                Console.WriteLine("1.Find maximum integer");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Please enter 3 integers.");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int z = Convert.ToInt32(Console.ReadLine());
                        FindMaxValue.FindMaximumValue(x, y, z);
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
