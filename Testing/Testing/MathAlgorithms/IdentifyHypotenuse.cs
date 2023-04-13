using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.MathAlgorithms
{
    public class IdentifyHypotenuse
    {
        /// <summary>
        /// IdentifyHypotenuse's Constructor.
        /// </summary>
        public IdentifyHypotenuse() { }

        /// <summary>
        /// Verify a range between 1 and N returning the numbers that contains hypotenuse and respectives sides.
        /// </summary>
        public void IdentifyHypotenuseAndSides()
        {
            Console.WriteLine("\n----------------\nThis will verify and print the numbers that contains hypotenuse and respectives sides.\n----------------");
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            int x, y;
            int aux;


            for (aux = num; aux > 1; aux--)
            {
                for (x = num; x > 1; x--)
                {
                    for (y = num; y > 1; y--)
                    {
                        if (aux * aux == (x * x) + (y * y))
                        {
                            Console.WriteLine($"{aux} is hypotenuse and sides are {x} and {y}");
                            continue;
                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
