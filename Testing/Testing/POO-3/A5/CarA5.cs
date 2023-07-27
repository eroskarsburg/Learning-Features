using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A5
{
    public class CarA5
    {
        public string Name { get; set; }
        public int Potency { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPotency: {Potency}";
        }
    }
}
