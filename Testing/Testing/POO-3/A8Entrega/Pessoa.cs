using System;

namespace Testing.POO_3.A8Entrega
{
	public class Pessoa
	{
        public String Nome { get; set; }
        public Endereco Endereco { get; set; }

		public Pessoa(string nome, Endereco endereco)
		{
			Nome = nome;
			Endereco = endereco;
		}

		public override string ToString()
		{
			return $"Nome: {Nome}\n Endereço: {Endereco}\n";
		}
	}
}
