using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A9Exam
{
	public class PessoaExam
	{
        private string Nome { get; set; }
        private TelefoneExam Telefone { get; set; }

        public PessoaExam() { }

		public PessoaExam(string nome)
		{
			Nome = nome;
		}

		public override string ToString()
		{
			return $"Nome: {Nome},\nTelefone: {Telefone}";
		}
	}
}
