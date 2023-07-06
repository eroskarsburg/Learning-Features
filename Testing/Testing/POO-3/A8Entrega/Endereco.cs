using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A8Entrega
{
	public class Endereco
	{
        public String Rua { get; set; }
        public String Cidade { get; set; }

		public Endereco(string rua, string cidade)
		{
			Rua = rua;
			Cidade = cidade;
		}

		public override string ToString()
		{
			return $"Rua: {Rua}, Cidade: {Cidade}";
		}
	}
}
