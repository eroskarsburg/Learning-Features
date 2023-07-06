using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Reflection;

namespace Testing.ADS
{
	public class ADSEx
	{
		public static List<String> Questions = new List<String>();
		public static List<String> CorrectAnswers = new List<String>();
		public static int ContAcertos { get; set; }
		public static int ContErros { get; set; }
		public static int Pontuacao { get; set; } = 0;

		public static void StartGame()
		{
			ReturnQuestions();
			List<String> correctAnsw = ReturnCorrectAnswers();
			Console.WriteLine("\n##Jogo Quiz##\nLeia cada questão, responda com a letra da alternativa que você escolher." +
					"\nPara SAIR antes de finalizar, pressione a tecla [ESC]\n");

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"\n> Pergunta {i + 1}:\n{Questions[i]}");
				for (int j = 0; j < 3; j++)
				{
					Console.WriteLine(ReturnAnswers(i + 1));
					string answ = Console.ReadLine();
					if (answ == correctAnsw[i])
					{
						Console.WriteLine("\nVocê acertou!");
						ContAcertos++;
						Pontuacao += 10;
						j = 3;
					}
					else
					{
						Console.WriteLine("\nResposta incorreta, você possui mais uma tentativa:");
						answ = Console.ReadLine();
						if (answ == correctAnsw[i])
						{
							Console.WriteLine("\nVocê acertou na segunda tentativa!");
							ContAcertos++;
							Pontuacao += 5;
							j = 3;
						}
						else
						{
							Console.WriteLine("\nVocê errou...");
							j = 3;
							ContErros++;
						}
					}
				}
			}

            Console.WriteLine("\nCalculando pontuação...");
            Console.WriteLine("\n### PONTUAÇÃO TOTAL ###");
            Console.WriteLine($"> {Pontuacao}.\n>{MensagemPontuacao(Pontuacao)}\nQuantidade de Acertos: {ContAcertos}.\nQuantidade de Erros: {ContErros}.");

        }

		public static string MensagemPontuacao(int pontuacao)
		{
			if (pontuacao == 100) { return "Excelente!"; }
			else if (pontuacao >= 75 && pontuacao <= 99) { return "Ótimo!"; }
			else if (pontuacao >= 50 && pontuacao <= 74) { return "Bom!"; }
			else if (pontuacao >= 25 && pontuacao <= 49) { return "Regular."; }
			else { return "Péssimo..."; }
		}

		public static List<String> ReturnQuestions()
		{
			Questions.Add("Uma estrutura de dados do tipo registro é:");
			Questions.Add("Uma estrutura multidimensional conta com:");
			Questions.Add("Vetores podem ter duas dimensões?");
			Questions.Add("É necessário um software para interpretação para linguagem HTML?");
			Questions.Add("Estes são operadores matemáticos:");
			Questions.Add("O operador NÃO age de que forma?");
			Questions.Add("Qual é o paradigma que possui pontos em comum com a prograação estruturada?");
			Questions.Add("O que é uma variável?.");
			Questions.Add("Para saída de dados usa-se a palavra reservada:");
			Questions.Add("Sobre estrutura de decisão, escolha a incorreta:");

			return Questions;
		}

		public static string ReturnAnswers(int index)
		{
			switch (index)
			{
				case 1:
					return "\n(A) Uma estrutura de dados homogênea.\n(B) Uma estrutura do tipo vetor.\n(C) Uma estrutura de dados heterogênea.\n";
				case 2:
					return "\n(A) Matriz.\n(B) Vetores.\n(C) Nenhuma das alternativas.\n";
				case 3:
					return "\n(A) Não, somente matrizes.\n(B) Sim.\n(C) Não, somente um cubo, por exemplo.\n";
				case 4:
					return "\n(A) Não, pois a interpretação é desnecessária.\n(B) Não, esta tem recursos próprios para interpretação." +
						"\n(C) Sim, como os navegadores para internet.\n";
				case 5:
					return "\n(A) >, >=, <, <=\n(B) +, -, /\n(C) E, OU, NAO\n";
				case 6:
					return "\n(A) Para ser verdadeiro, todas as expressões analisadas devem ser verdadeiras." +
						"\n(B) Apenas inverte o valor verdadeiro ou falso.\n(C) Não existe operador NÃO.\n";
				case 7:
					return "\n(A) Paradigma Orientação a Discretos.\n(B) Paradigma Orientação a Concretos.\n(C) Nenhuma das alternativas.\n";
				case 8:
					return "\n(A) É uma constante na declaração de dados.\n(B) É um espaço criado na memória para armazenar dados." +
						"\n(C) Uma estrutura que deve conter sempre somente caracteres.\n";
				case 9:
					return "\n(A) Escreva\n(B) Leia\n(C) Senão\n";
				case 10:
					return "\n(A) Pode ser uma estrutura aninhada.\n(B) O SE sempre vem acompanhado do SENÃO." +
						"\n(C) A palavra reservada mais conhecida para este tipo de instrução é SE.\n";
				default:
					return "";
			}
		}

		public static List<String> ReturnCorrectAnswers()
		{
			CorrectAnswers.Add("C");
			CorrectAnswers.Add("A");
			CorrectAnswers.Add("A");
			CorrectAnswers.Add("C");
			CorrectAnswers.Add("B");
			CorrectAnswers.Add("B");
			CorrectAnswers.Add("C");
			CorrectAnswers.Add("B");
			CorrectAnswers.Add("A");
			CorrectAnswers.Add("B");

			return CorrectAnswers;
		}
	}
}
