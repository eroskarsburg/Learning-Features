using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A4Entrega
{
    public class Payroll
    {
        public String Name { get; set; }
        public float Wage { get; set; }
        public String SecondName { get; set; }
        public float SecondWage { get; set; }

        public float TotalFolhaPagamento() { return Wage + SecondWage; }

        public override string ToString()
        {
            return $"Payroll Properties.\nFirst Name: {Name},\nFirst Wage: {Wage},\n" +
                $"Second Name: {SecondName},\nSecond Wage: {SecondWage}.\n";
        }
    }
}
