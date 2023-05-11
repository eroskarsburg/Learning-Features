using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A2
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        internal string ShowProductName() { return Name; }
        internal float ShowPrice() { return Price; }
        internal string ShowProductDescription() { return Description; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Name == product.Name;
        }

        public override string ToString()
        {
            return $"\nProduct:\nName: {Name}\nDescription: {Description}\nPrice: {Price}.";
        }
    }
}
