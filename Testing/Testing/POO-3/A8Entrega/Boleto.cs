using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Testing.POO_3.A2;

namespace Testing.POO_3.A8Entrega
{
	public class Boleto
	{
        public Pessoa Pagador { get; set; }
        public Pessoa Beneficiario { get; set; }
        public float ValorDocumento { get; set; }
        public String DataPagamento { get; set; }
        public int CodigoDocumento { get; set; }

		public Boleto(Pessoa pagador, Pessoa beneficiario, float valorDocumento)
		{
			Pagador = pagador;
			Beneficiario = beneficiario;
			ValorDocumento = valorDocumento;
		}

		public override string ToString()
		{
			return $"\n-> Pagador: {Pagador}\n-> Beneficiário: {Beneficiario}\n-> Valor do Documento: {ValorDocumento}\n" +
				$"-> Data do Pagamento: {DataPagamento}\n-> Código do Documento: {CodigoDocumento}";
		}

		public override bool Equals(object obj)
		{
			return obj is Boleto boleto &&
				   CodigoDocumento == boleto.CodigoDocumento;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
