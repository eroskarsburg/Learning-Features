using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3
{
    public class TestMethods
    {
        public void RetornaNomeEndereco()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu endereço: ");
            string endereco = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}");
        }

        public void CalculaAreaQuadrado()
        {
            Console.WriteLine("Digite o lado A: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B: ");
            float y = float.Parse(Console.ReadLine());

            float area = x * y;
            Console.WriteLine($"Área: {area}");
        }

        public void VerificaNumeroMaior()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"{x} é maior que {y}");
            }
            else if (x < y)
            {
                Console.WriteLine($"{y} é maior que {x}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        public void CalculaMediaAluno()
        {
            Console.WriteLine("Digite a primeira nota: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            float z = float.Parse(Console.ReadLine());

            float media = (x + y + z) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado.");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Recuperação.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }

        }

        public void RetornaNumeroUmToCem()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void VerificaParOuImpar()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Número par: {i}");
                }
                else
                {
                    Console.WriteLine($"Número ímpar: {i}");
                }
            }
        }
    }
}
