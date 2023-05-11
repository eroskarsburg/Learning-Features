using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A4Entrega
{
    public class Motorcycle
    {
        public String Name { get; set; }
        public String Brand { get; set; }
        public int Power { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Motorcycle Properties.\nName: {Name},\nBrand: {Brand},\nPower: {Power},\nWeight: {Weight}.\n";
        }
    }
}
