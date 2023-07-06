using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A9Exam
{
	public class Monitor : Teste
	{
        public int Polegadas { get; set; }
        public int Cor { get; set; }
		public string Marca { get; set; }

		public Monitor(int polegadas, int cor, string marca)
		{
			Polegadas = polegadas;
			Cor = cor;
			Marca = marca;
		}

		protected void Sla()
		{
			Teste teste = new Teste();
			sla();
		}

		public override string ToString()
		{
			return $"Polegadas: {Polegadas}\nCor: {Cor}\nMarca: {Marca}.";
		}
	}
}
