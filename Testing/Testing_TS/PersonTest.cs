using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing;
using Testing.POO_3.A2;
using Testing.POO_3.A8Entrega;

namespace Testing_TS
{
	public class PersonTest
	{
		Person pessoa;

		[SetUp]
		public void Setup()
		{
			pessoa = new Person();
		}

		[Test]
		public void testConcatenaNomeSobreNome()
		{
			String nome = "Pedro";
			String sobreNome = "Silva";
			String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
			Assert.AreEqual("PedroSilva", resultadoPrograma);
		}

		[Test]
		public void testConcatenaNomeSobreNomeVazio()
		{
			String nome = String.Empty;
			String sobreNome = String.Empty;
			String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
			Assert.AreEqual(String.Empty, resultadoPrograma);
		}

		[Test]
		public void testConcatenaNomeSobreNomeComNull()
		{
			String nome = null;
			String sobreNome = null;
			String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
			Assert.AreEqual(String.Empty, resultadoPrograma);
		}

		[Test]
		public void testeMaiorIdadeComValorMaior18()
		{
			bool resultadoPrograma = pessoa.eMaiorIdade(18);
			Assert.IsTrue(resultadoPrograma);
		}

		[Test]
		public void testeMaiorIdadeComValorMenor18()
		{
			// arrange

			// ack
			bool resultadoPrograma = pessoa.eMaiorIdade(17);

			// assert
			Assert.IsFalse(resultadoPrograma);
		}


		[Test]
		public void testeretornaTamanhoTextoValorOk()
		{
			// arrange
			String entrada = "casa";
			int resultadoExperado = 4;

			// ack
			int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

			// assert
			Assert.AreEqual(resultadoExperado, resultadoPrograma);
		}

		[Test]
		public void testeretornaTamanhoTextoValorVazio()
		{
			// arrange
			String entrada = "";
			int resultadoExperado = 0;

			// ack
			int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

			// assert
			Assert.AreEqual(resultadoExperado, resultadoPrograma);
		}

		[Test]
		public void testeretornaTamanhoTextoValorNull()
		{
			// arrange
			String entrada = null;
			int resultadoExperado = -1;

			// ack
			int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

			// assert
			Assert.AreEqual(resultadoExperado, resultadoPrograma);
		}
	}
}
