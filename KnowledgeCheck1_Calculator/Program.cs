using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
            var input = Console.ReadLine();

            Console.WriteLine("Enter two numbers (press enter after each)");
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Adding...");

                    if (int.TryParse(firstNumber, out int addNumOne) && int.TryParse(secondNumber, out int addNumTwo))
                    {
                        Console.Write($"{firstNumber} + {secondNumber} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Subtracting...");

                    if (int.TryParse(firstNumber, out int subNumOne) && int.TryParse(secondNumber, out int subNumTwo))
                    {
                        Console.Write($"{firstNumber} - {secondNumber} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Multiplying...");

                    if (int.TryParse(firstNumber, out int multNumOne) && int.TryParse(secondNumber, out int multNumTwo))
                    {
                        Console.Write($"{firstNumber} x {secondNumber} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Dividing...");

                    if (double.TryParse(firstNumber, out double divNumOne) && double.TryParse(secondNumber, out double divNumTwo))
                    {
                        Console.Write($"{firstNumber} / {secondNumber} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}