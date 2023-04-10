using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.MathAlgorithms
{
    public class MathOperators
    {
        public MathOperators() { }

        public void MathOperations()
        {
            Console.WriteLine("\nMath Operators\n----------------\n");
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz Quadrada");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                case 6:
                    resultado = Math.Sqrt(num1);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }
}
