using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A2
{
    public class FiscalNote
    {
        public string NameFirstItem { get; set; }
        public string NameSecondItem { get; set; }
        public float PriceFirstItem { get; set; }
        public float PriceSecondItem { get; set; }

        internal float CalculateFiscalNote(float fstValue, float scndValue) { return fstValue + scndValue; }
        internal string ShowNameFirstItem() { return NameFirstItem; }
        internal string ShowNameSecondItem() { return NameSecondItem; }
    }
}
