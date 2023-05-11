using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A2
{
    public class Calculator
    {
        public int CalculusValue { get; set; }
        public float FirstValue { get; set; }
        public float SecondValue { get; set; }
        public string Operation { get; set; }

        internal float ReturnSum() { return FirstValue + SecondValue; }
        internal float ReturnSubtract() { return FirstValue - SecondValue; }
        internal int LastResult() { return CalculusValue; }
        internal string LastOperation() { return Operation; }

        public override bool Equals(object obj)
        {
            return obj is Calculator calculator &&
                   Operation == calculator.Operation;
        }

        public override string ToString()
        {
            return $"\nCalculator:\nFirst Value: {FirstValue}\nSecond Value: {SecondValue}\nOperation: {Operation}.";
        }
    }
}
