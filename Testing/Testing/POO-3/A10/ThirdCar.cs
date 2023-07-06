using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A10
{
	public class ThirdCar
	{
        public string Nome { get; set; }
		public string Marca { get; set; }
        public int Potencia { get; set; }

        public ThirdCar() { }

        public void MontaCarro(string nome, string marca, int potencia)
		{
			this.Nome = nome;
			this.Marca = marca;
			this.Potencia = potencia;

			Console.WriteLine($"Nome: {nome}, Marca: {marca}, Potência: {potencia}");
		}

		public void MontaCarro(string nome, string marca)
		{
			this.Nome = nome;
			this.Marca = marca;

			Console.WriteLine($"Nome: {nome}, Marca: {marca}");
		}

		public void MontaCarro(string nome, int potencia)
		{
			this.Nome = nome;
			this.Potencia = potencia;

            Console.WriteLine($"Nome: {nome}, Potência: {potencia}");
        }
	}
}
