using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A2
{
    public class Computer
    {
        public string Name { get; set; }
        public int Clock { get; set; }

        internal string ShowComputerName() { return Name; }
        internal int ShowClock() { return Clock; }

        public override bool Equals(object obj)
        {
            return obj is Computer computer &&
                   Name == computer.Name;
        }

        public override string ToString()
        {
            return $"Infos:\nName: {Name}\nClock: {Clock}";
        }
    }
}
