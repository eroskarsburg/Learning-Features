using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Digite o primeiro número: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Selecione uma operação:");
            //Console.WriteLine("1 - Adição");
            //Console.WriteLine("2 - Subtração");
            //Console.WriteLine("3 - Multiplicação");
            //Console.WriteLine("4 - Divisão");
            //Console.WriteLine("5 - Potência");
            //Console.WriteLine("6 - Raiz Quadrada");
            //int operacao = int.Parse(Console.ReadLine());

            //double resultado = 0;

            //switch (operacao)
            //{
            //    case 1:
            //        resultado = num1 + num2;
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    case 2:
            //        resultado = num1 - num2;
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    case 3:
            //        resultado = num1 * num2;
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    case 4:
            //        resultado = num1 / num2;
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    case 5:
            //        resultado = Math.Pow(num1, num2);
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    case 6:
            //        resultado = Math.Sqrt(num1);
            //        Console.WriteLine("Resultado: " + resultado);
            //        Console.WriteLine("Pressione qualquer tecla para sair.");
            //        Console.ReadKey();
            //        break;
            //    default:
            //        Console.WriteLine("Operação inválida");
            //        break;
            //}

            //Console.WriteLine("Insira um número: ");
            //int number = int.Parse(Console.ReadLine());
            //int x = number;
            //int contPrimos = 0;

            //while (number > 0)
            //{
            //    if (x % number == 0)
            //    {
            //        Console.WriteLine($"X: {number}");
            //        number--;
            //        contPrimos++;
            //    }
            //    else
            //    {
            //        number--;
            //    }
            //}

            //if (contPrimos == 2)
            //{
            //    Console.WriteLine($"O número {x} é primo!");
            //}
            //else
            //{
            //    Console.WriteLine($"O número {x} NÃO é primo!");
            //}
            //Console.ReadKey();

            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            int x, y = num;
            int aux = num;


            for (aux = num; aux > 1; aux--)
            {
                for (x = num; x > 1; x--)
                {
                    for (y = num; y > 1; y--)
                    {
                        if (aux * aux == (x * x) + (y * y))
                        {
                            Console.WriteLine($"{aux} é hipotenusa dos catetos {x} e {y}");
                            continue;
                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
