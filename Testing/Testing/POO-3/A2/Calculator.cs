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
        public string Operation { get; set; }

        internal int SumValues(int fstValue, int scndValue) { return fstValue + scndValue; }
        internal int SubtractValues(int fstValue, int scndValue) { return fstValue - scndValue; }
        internal int LastResult() { return CalculusValue; }
        internal string LastOperation() { return Operation; }
    }
}
