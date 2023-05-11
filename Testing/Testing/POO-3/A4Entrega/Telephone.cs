using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A4Entrega
{
    public class Telephone
    {
        public int TelephoneNumber { get; set; }
        public String Operator { get; set; }

        public void ReturnTelephoneNumber()
        {
            Console.WriteLine(TelephoneNumber);
        }
        public void ReturnOperator()
        {
            Console.WriteLine(Operator);
        }

        public override string ToString()
        {
            return $"Telephone Properties.\nNumber: {TelephoneNumber},\nOperator: {Operator}.\n";
        }
    }
}
