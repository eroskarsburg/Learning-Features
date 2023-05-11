using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A4Entrega
{
    public class Car
    {
        public String Name { get; set; }
        public int Power { get; set; }

        public void ReturnName()
        {
            Console.WriteLine(Name);
        }
        public void ReturnPower()
        {
            Console.WriteLine(Power);
        }

        public override string ToString()
        {
            return $"Car Properties.\nName: {Name},\nPower: {Power}.\n";
        }
    }
}
