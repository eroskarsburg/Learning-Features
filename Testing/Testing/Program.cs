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
            IdentifyPrimeNumbers primeNumbers = new IdentifyPrimeNumbers();
            primeNumbers.PrimeNumbers();

            MathOperators operators = new MathOperators();
            operators.MathOperations();

            IdentifyHypotenuse hypotenuse = new IdentifyHypotenuse();
            hypotenuse.IdentifyHypotenuseAndSides();
        }
    }
}
