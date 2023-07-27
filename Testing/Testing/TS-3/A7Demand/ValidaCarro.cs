using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TS
{
    public class ValidaCarro
    {
		Carro carro = new Carro();

		public ValidaCarro() { }

		public ValidaCarro(Carro carro)
		{
			this.carro.modelo = carro.modelo;
			this.carro.marca = carro.marca;
			this.carro.placa = carro.placa;
			this.carro.anoFabricacao = carro.anoFabricacao;
			this.carro.nomeProprietario = carro.nomeProprietario;
		}

		public bool ValidaIdMaiorZero(int id)
		{
			if (id > 0) return true;
			else throw new ArgumentException("O Id não pode ser menor que Zero.");
		}

		public string ValidaModelo(string modelo)
		{
			bool tamanhoPermitido = modelo.Length > 0 && modelo.Length <= 20;
			if (tamanhoPermitido) return "Modelo válido.";
			else throw new ArgumentException("O Modelo deve possuir, no máximo, 20 caracteres.");
		}

		public string ValidaMarcasPermitidas(string marca)
		{
			bool marcasPermitidas = marca.Contains("VW") || marca.Contains("Ford") || marca.Contains("GM") || marca.Contains("Fiat");
			if (marcasPermitidas) return "Marcas válidas.";
			else throw new ArgumentException("A marca digitada não possui permissão na aplicação.");
		}

		public bool ValidaTotalCharsPlaca(string placa)
		{
			bool tamanhoPermitido = placa.Length == 8;
			if (tamanhoPermitido) return true;
			else return false;
		}

		public string ValidaAnoFabricacao(int anoFabricacao)
		{
			if (anoFabricacao >= 1980) return "Ano válido.";
			else throw new ArgumentException("O Ano deve ser maior/igual a 1980.");
		}

		public string ValidaNomeProprietario(string nomeProp)
		{
			bool tamanhoPermitido = nomeProp.Length > 0 && nomeProp.Length <= 25;
			if (tamanhoPermitido) return "Nome válido.";
			else throw new ArgumentException("O Nome do proprietário deve possuir, no máximo, 25 caracteres.");
		}

		public string ValidaValorTotal(int valorTotal)
		{
			bool tamanhoPermitido = valorTotal >= 1 && valorTotal <= 50000;
			if (tamanhoPermitido) return "Preço válido";
			else throw new ArgumentException("O Preço deve ser, no máximo, até 50 mil reais.");
		}

		public string ValidaValorFinanciamento(int valorFinanciamento, bool isFinanciado = false)
		{
			if (isFinanciado) return ValidaValorTotal(valorFinanciamento);
			else throw new ArgumentException("Carro não é financiado.");
		}
	}
}
