using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A9Exam
{
	public class TelefoneExam
	{
        private int DDD { get; set; }
		private int NumeroTelefone { get; set; }

        public void ConfigurarTelefone(int ddd, int numero)
        {
            Console.WriteLine($"DDD: {ddd},\nNúmero: {numero}.");
        }
    }
}
