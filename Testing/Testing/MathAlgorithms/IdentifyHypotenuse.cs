using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.MathAlgorithms
{
    public class IdentifyHypotenuse
    {
        public IdentifyHypotenuse() { }

        public void IdentifyHypotenuseAndSides()
        {
            Console.WriteLine("\n----------------\nThis will verify and print the numbers that contains hypotenuse and respectives sides.\n----------------");
            Console.WriteLine("Enter a number: ");
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
                            Console.WriteLine($"{aux} is hypotenuse ans sides are {x} and {y}");
                            continue;
                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
