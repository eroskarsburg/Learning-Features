using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A10
{
	public class Calculadora
	{
        public Calculadora() { }

		public int Soma(int a, int b)
		{
			return a + b;
		}

		public float Soma(float a, float b)
		{
			return a + b;
		}

		public double Soma(double a, double b)
		{
			return a + b;
		}

		public int Soma(int a, int b, int c)
		{
			return a + b + c;
		}

		public float Soma(float a, float b, float c)
		{
			return a + b + c;
		}

		public double Soma(double a, double b, double c)
		{
			return a + b + c;
		}
	}
}
