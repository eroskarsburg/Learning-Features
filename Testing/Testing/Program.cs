using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.MathAlgorithms;

namespace Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {

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

            MathOperators mathOperators = new MathOperators();
            mathOperators.MathOperations();

            IdentifyHypotenuse hypotenuse = new IdentifyHypotenuse();
            hypotenuse.IdentifyHypotenuseAndSides();
        }
    }
}
