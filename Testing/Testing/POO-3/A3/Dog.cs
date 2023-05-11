using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A3
{
    public class Dog
    {
        public String Name { get; set; }
        public String Raca { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The dog's name is {Name}.");
        }
    }
}
