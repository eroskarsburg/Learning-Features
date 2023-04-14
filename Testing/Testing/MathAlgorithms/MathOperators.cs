using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.MathAlgorithms
{
    public class MathOperators
    {
        /// <summary>
        /// MathOperators' Constructor.
        /// </summary>
        public MathOperators() { }

        /// <summary>
        /// Returns a math calculation resolution based on selected math operator.
        /// </summary>
        public void MathOperations()
        {
            Console.WriteLine("\nMath Operators\n----------------\n");
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select an operator:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Power");
            Console.WriteLine("6 - Square Root");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                case 6:
                    resultado = Math.Sqrt(num1);
                    Console.WriteLine("Result: " + resultado);
                    Console.WriteLine("Press any button to quit.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        internal float ReturnMathOperationResult(float fstNumber, float scndNumber, string operation)
        {
            return 2.3;
        }
    }
}
