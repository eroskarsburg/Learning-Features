using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A4Entrega
{
    public class Persona
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Adress { get; set; }

        public void ReturnName()
        {
            Console.WriteLine(Name);
        }
        public void ReturnAge()
        {
            Console.WriteLine(Age);
        }
        public void ReturnAdress()
        {
            Console.WriteLine(Adress);
        }

        public override string ToString()
        {
            return $"Person Properties.\nName: {Name},\nAge: {Age},\nAdress: {Adress}.\n";
        }
    }
}
