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
                    "3.Find maximum string value with generic method\n4.Method extended to take more input\n" +
                    "5.Calling PrintMax method from TestMaximum method");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter 3 integers.");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int z = Convert.ToInt32(Console.ReadLine());
                        FindMaxValue<int> findMaxValue = new FindMaxValue<int>(x, y, z);
                        findMaxValue.TestMaximum();
                        break;

                    case 2:
                        Console.WriteLine("Please enter 3 float values.");
                        float x1 = float.Parse(Console.ReadLine());
                        float y1 = float.Parse(Console.ReadLine());
                        float z1 = float.Parse(Console.ReadLine());
                        FindMaxValue<float> findMaxFloat = new FindMaxValue<float>(x1, y1, z1);
                        findMaxFloat.TestMaximum();
                        break;

                    case 3:
                        Console.WriteLine("Please enter 3 string values.");
                        string x2 = Console.ReadLine();
                        string y2 = Console.ReadLine();
                        string z2 = Console.ReadLine();
                        FindMaxValue<string> findMaxString = new FindMaxValue<string>(x2, y2, z2);
                        findMaxString.TestMaximum();
                        break;

                    case 4:
                        Console.WriteLine("Please select datatypes:");
                        Console.WriteLine("1.Integer values\n2.Float values\n3.String values");
                        int select = Convert.ToInt32(Console.ReadLine());
                        switch(select)
                        {
                            case 1:
                                // Sample integers
                                Console.Write("Enter integer values separated by spaces: ");
                                string intInput = Console.ReadLine();
                                int[] intValues = Array.ConvertAll(intInput.Split(' '), int.Parse);
                                FindMaxValue<int> intFinder = new FindMaxValue<int>(intValues);
                                intFinder.TestMaximum();
                                break;

                            case 2:
                                // Sample floats
                                Console.Write("Enter float values separated by spaces: ");
                                string floatInput = Console.ReadLine();
                                float[] floatValues = Array.ConvertAll(floatInput.Split(' '), float.Parse);
                                FindMaxValue<float> floatFinder = new FindMaxValue<float>(floatValues);
                                floatFinder.TestMaximum();
                                break;

                            case 3:
                                // Sample strings
                                Console.Write("Enter string values separated by spaces: ");
                                string stringInput = Console.ReadLine();
                                string[] stringValues = stringInput.Split(' ');
                                FindMaxValue<string> stringFinder = new FindMaxValue<string>(stringValues);
                                stringFinder.TestMaximum();
                                break;

                        }
                        break;

                    case 5:
                        Console.WriteLine("Please select datatypes:");
                        Console.WriteLine("1.Integer values\n2.Float values\n3.String values");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                // Sample integers
                                Console.Write("Enter integer values separated by spaces: ");
                                string intInput = Console.ReadLine();
                                int[] intValues = Array.ConvertAll(intInput.Split(' '), int.Parse);
                                FindMaxValue<int> intFinder = new FindMaxValue<int>(intValues);
                                intFinder.TestMaximum();
                                break;

                            case 2:
                                // Sample floats
                                Console.Write("Enter float values separated by spaces: ");
                                string floatInput = Console.ReadLine();
                                float[] floatValues = Array.ConvertAll(floatInput.Split(' '), float.Parse);
                                FindMaxValue<float> floatFinder = new FindMaxValue<float>(floatValues);
                                floatFinder.TestMaximum();
                                break;

                            case 3:
                                // Sample strings
                                Console.Write("Enter string values separated by spaces: ");
                                string stringInput = Console.ReadLine();
                                string[] stringValues = stringInput.Split(' ');
                                FindMaxValue<string> stringFinder = new FindMaxValue<string>(stringValues);
                                stringFinder.TestMaximum();
                                break;

                        }
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
