using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A10
{
	public class Relogio
	{
        public int Segundo { get; set; }
        public int Minuto { get; set; }
        public int Hora { get; set; }

        public Relogio() { }

        public Relogio(int segundo, int minuto, int hora)
		{
			Segundo = segundo;
			Minuto = minuto;
			Hora = hora;
		}

		public void ConfiguraHorario(int segundo, int minuto, int hora)
		{
			this.Segundo = segundo;
			this.Minuto = minuto;
			this.Hora = hora;

			Console.WriteLine($"Segundo: {segundo}, Minuto: {minuto}, Hora: {hora}\n");
		}

		public void ConfiguraHorario(int segundo, int minuto)
		{
			this.Segundo = segundo;
			this.Minuto = minuto;

            Console.WriteLine($"Segundo: {segundo}, Minuto: {minuto}");
        }

	}
}
