using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.MathAlgorithms
{
    public class IdentifyPrimeNumbers
    {
        /// <summary>
        /// IdentifyPrimeNumbers' Constructor.
        /// </summary>
        public IdentifyPrimeNumbers() { }

        /// <summary>
        /// Returns numbers between 1 and N that are primes.
        /// </summary>
        public void PrimeNumbers()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int x = number;
            int contPrimos = 0;

            while (number > 0)
            {
                if (x % number == 0)
                {
                    Console.WriteLine($"X: {number}");
                    number--;
                    contPrimos++;
                }
                else
                {
                    number--;
                }
            }

            if (contPrimos == 2)
            {
                Console.WriteLine($"Number {x} is prime!");
            }
            else
            {
                Console.WriteLine($"Number {x} ISN'T prime!");
            }
            Console.ReadKey();
        }
    }
}
