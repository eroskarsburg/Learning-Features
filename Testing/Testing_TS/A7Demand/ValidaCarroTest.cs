using Moq;
using NUnit.Framework;
using System;
using TS;

namespace Testing_TS.A7Demand
{
	public class ValidaCarroTest
	{
		Carro carro;
		Mock<Carro> carroMocked;
		ValidaCarro valida;
		Mock<ValidaCarro> validaMocked;

		[SetUp]
		public void Setup()
		{
			carro = new Carro();
			valida = new ValidaCarro();
			carroMocked = new Mock<Carro>();
			validaMocked = new Mock<ValidaCarro>();
		}

		[Test]
		public void ValidaIdMaiorZeroTestTrue()
		{
			//Arrange
			carro.codigo = 2;
			//Act
			bool retorno = valida.ValidaIdMaiorZero(carro.codigo);
			//Assert
			Assert.IsTrue(retorno);
		}

		[Test]
		public void ValidaIdMaiorZeroTestMock()
		{
			//Arrange
			carro.codigo = 1;
			var validateMocked = validaMocked.Setup(x => x.ValidaIdMaiorZero(carro.codigo)).Returns(true);
			//Act
			bool retorno = valida.ValidaIdMaiorZero(carro.codigo);
			//Assert
			Assert.That(retorno, Is.EqualTo(validateMocked));
		}

		[Test]
		public void ValidaIdMaiorZeroTestFalse()
		{
			//Arrange
			carro.codigo = 0;
			//Act
			//Assert
			Assert.Throws<ArgumentException>(() =>
					valida.ValidaIdMaiorZero(carro.codigo));
		}

		[Test]
		public void ValidaModeloTestValido()
		{
			//Arrange
			carro.modelo = "ABCDEFGHIJKLMNOP";
			//Act
			string retorno = valida.ValidaModelo(carro.modelo);
			//Assert
			Assert.AreEqual(retorno, "Modelo válido.");
		}

		[Test]
		public void ValidaModeloTestInvalido()
		{
			//Arrange
			carro.modelo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			//Act
			//Assert
			Assert.Throws<ArgumentException>(() => valida.ValidaModelo(carro.modelo));
		}

		[Test]
		public void ValidaMarcasPermitidasTest()
		{
			carro.marca = "VW";
			string retorno = valida.ValidaMarcasPermitidas(carro.marca);
			Assert.AreEqual(retorno, "Marcas válidas.");
		}
		
		[Test]
		public void ValidaMarcasNaoPermitidasTest()
		{
			//Arrange
			carro.marca = "BLABLA";
			//Act
			//Assert
			Assert.Throws<ArgumentException>(() => valida.ValidaMarcasPermitidas(carro.marca));
		}

		[Test]
		public void ValidaTotalCharsPlacaTestValido()
		{
			//Arrange
			carro.placa = "VCX-1093";
			//Act
			bool retorno = valida.ValidaTotalCharsPlaca(carro.placa);
			//Assert
			Assert.IsTrue(retorno);
		}

		[Test]
		public void ValidaTotalCharsPlacaTestInvalido()
		{
			//Arrange
			carro.placa = "SJKÇASDHAFHUAISBDN";
			//Act
			bool retorno = valida.ValidaTotalCharsPlaca(carro.placa);
			//Assert
			Assert.IsFalse(retorno);
		}

		[Test]
		public void ValidaAnoFabricacaoTestPermitido()
		{
			carro.anoFabricacao = 1990;
			string retorno = valida.ValidaAnoFabricacao(carro.anoFabricacao);
			Assert.AreEqual(retorno, "Ano válido.");
		}

		[Test]
		public void ValidaAnoFabricacaoTestNaoPermitido()
		{
			carro.anoFabricacao = 1920;
			Assert.Throws<ArgumentException>(() => valida.ValidaAnoFabricacao(carro.anoFabricacao));
		}

		[Test]
		public void ValidaNomeProprietarioTestValido()
		{
			carro.nomeProprietario = "Eros Karsburg";
			string retorno = valida.ValidaNomeProprietario(carro.nomeProprietario);
			Assert.AreEqual(retorno, "Nome válido.");
		}

		[Test]
		public void ValidaNomeProprietarioTestInvalido()
		{
			carro.nomeProprietario = "SAOIJPASOUHFIOAJNDIASNHDOPASHDU";
			Assert.Throws<ArgumentException>(() => valida.ValidaNomeProprietario(carro.nomeProprietario));
		}

		[Test]
		public void ValidaValorTotalFinanciado()
		{
			carro.valorFinanciamento = 40000;
			carro.eFinanciado = true;
			string retorno = valida.ValidaValorFinanciamento(carro.valorFinanciamento, carro.eFinanciado);
			Assert.AreEqual(retorno, "Preço válido");
		}

		[Test]
		public void ValidaValorTotalTest()
		{
			carro.valorTotal = 50000;
			string retorno = valida.ValidaValorTotal(carro.valorTotal);
			Assert.AreEqual(retorno, "Preço válido");
		}

		[Test]
		public void ValidaValorTotalTestInvalido()
		{
			carro.valorTotal = 50001;
			Assert.Throws<ArgumentException>(() => valida.ValidaValorTotal(carro.valorTotal));
		}
	}
}
