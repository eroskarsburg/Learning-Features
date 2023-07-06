using System;
using Testing.ADS;
using Testing.POO_3.A10;
using Testing.POO_3.A9Exam;

namespace Testing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			#region - x -

			//IdentifyPrimeNumbers primeNumbers = new IdentifyPrimeNumbers();
			//primeNumbers.PrimeNumbers();

			//MathOperators operators = new MathOperators();
			//operators.MathOperations();

			//IdentifyHypotenuse hypotenuse = new IdentifyHypotenuse();
			//hypotenuse.IdentifyHypotenuseAndSides();

			//Computer comp = new Computer();
			//comp.Clock = 4123;

			//Computer compTwo = new Computer();
			//compTwo.Clock = 21736;

			//comp.ShowClock();
			//compTwo.ShowClock();

			////

			//Product prod = new Product();
			//prod.Name = "Apple";
			//prod.Description = "Fruit";
			//prod.Price = 10.2f;

			//Product prodTwo = new Product();
			//prodTwo.Name = "Banana";
			//prodTwo.Description = "Fruit";
			//prodTwo.Price = 4.5f;

			//List<Product> prodList = new List<Product>();
			//prodList.Add(prod);
			//prodList.Add(prodTwo);

			//foreach (var prodItem in prodList)
			//{
			//    if (prodList.Contains(prodItem) || prodList.Contains(prodItem))
			//    {
			//        Console.WriteLine(prodItem);
			//    }
			//}

			////

			//Calculator calculator = new Calculator();
			//Console.WriteLine("\nInsert the calculus operation: ");
			//calculator.Operation = Console.ReadLine();
			//Console.WriteLine("\nInsert the first value: ");
			//calculator.FirstValue = float.Parse(Console.ReadLine());
			//Console.WriteLine("\nInsert the second value: ");
			//calculator.SecondValue = float.Parse(Console.ReadLine());

			//Console.WriteLine(calculator);

			////EX: 1
			//Car car = new Car();
			//car.Name = "C4";
			//car.Power = 120;
			//Console.WriteLine(car.ToString());

			////EX: 2
			//Telephone telephone = new Telephone();
			//telephone.TelephoneNumber = 123456789;
			//telephone.Operator = "Vivo";

			//Telephone telephoneTwo = new Telephone();
			//telephoneTwo.TelephoneNumber = 987654321;
			//telephoneTwo.Operator = "Claro";

			//List<Telephone> telephList = new List<Telephone>();
			//telephList.Add(telephone);
			//telephList.Add(telephoneTwo);

			//foreach (var item in telephList)
			//{
			//    if (telephList.Contains(item) || telephList.Contains(item))
			//    {
			//        Console.WriteLine(item);
			//    }
			//}

			////EX: 3
			//Persona person = new Persona();
			//Console.WriteLine("\nInsert your name:");
			//person.Name = Console.ReadLine();
			//Console.WriteLine("\nInsert your age:");
			//person.Age = int.Parse(Console.ReadLine());
			//Console.WriteLine("\nInsert your adress:");
			//person.Adress = Console.ReadLine();

			//Persona personTwo = new Persona();
			//Console.WriteLine("\nInsert your name:");
			//personTwo.Name = Console.ReadLine();
			//Console.WriteLine("\nInsert your age:");
			//personTwo.Age = int.Parse(Console.ReadLine());
			//Console.WriteLine("\nInsert your adress:");
			//personTwo.Adress = Console.ReadLine();

			//List<Persona> personList = new List<Persona>();
			//personList.Add(person);
			//personList.Add(personTwo);

			//foreach (var item in personList)
			//{
			//    if (personList.Contains(item) || personList.Contains(item)) { Console.WriteLine(item); }
			//}

			////EX: 4
			//Payroll payroll = new Payroll();
			//Console.WriteLine("\nInsert a name:");
			//payroll.Name = Console.ReadLine();
			//while (payroll.Wage <= 0)
			//{
			//    Console.WriteLine("\nInsert a wage:");
			//    payroll.Wage = float.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("\nInsert a second name:");
			//payroll.SecondName = Console.ReadLine();
			//while (payroll.SecondWage <= 0)
			//{
			//    Console.WriteLine("\nInsert your wage:");
			//    payroll.SecondWage = float.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("\nTotal folha de pagamento: " + payroll.TotalFolhaPagamento() + "\n");
			//Console.WriteLine(payroll.ToString());

			////EX: 5
			//Motorcycle motorcycle = new Motorcycle();
			//motorcycle.Name = "Moto";
			//motorcycle.Brand = "Marca";
			//motorcycle.Power = 1200;
			//motorcycle.Weight = 230;

			//Motorcycle motorcycleTwo = new Motorcycle();
			//motorcycleTwo.Name = "Yamaha";
			//motorcycleTwo.Brand = "MarcaDois";
			//motorcycleTwo.Power = 1500;
			//motorcycleTwo.Weight = 340;

			//List<Motorcycle> motorcyclesList = new List<Motorcycle>();
			//motorcyclesList.Add(motorcycle);
			//motorcyclesList.Add(motorcycleTwo);

			//foreach (var item in motorcyclesList)
			//{
			//    if (motorcyclesList.Contains(item) || motorcyclesList.Contains(item)) { Console.WriteLine(item); }
			//}

			//CarA5 car = new CarA5();
			//car.Name = "Audi";
			//car.Potency = 1200;
			//Console.WriteLine(car.ToString());

			//         Endereco erosEndereco = new Endereco("General Neto", "Canoas");
			//Endereco viniEndereco = new Endereco("Angelina Vitta", "Vale dos Sinos");
			//Endereco marceloEndereco = new Endereco("Independencia", "São Leopoldo");

			//Pessoa eros = new Pessoa("Eros", erosEndereco);
			//Pessoa vinicius = new Pessoa("Vinicius", viniEndereco);
			//Pessoa marcelo = new Pessoa("Marcelo", marceloEndereco);

			//Boleto firstBoleto = new Boleto(eros, vinicius, 2000);
			//         firstBoleto.DataPagamento = "30/01/2023";
			//         firstBoleto.CodigoDocumento = 123456;

			//Boleto secondBoleto = new Boleto(eros, marcelo, 4500);
			//secondBoleto.DataPagamento = "20/05/2023";
			//secondBoleto.CodigoDocumento = 123456;

			//         //=====

			//Console.WriteLine($"Primeiro boleto: {firstBoleto}.\n");
			//Console.WriteLine($"\nSegundo boleto: {secondBoleto}.\n");

			//if (firstBoleto.Equals(secondBoleto))
			//             Console.WriteLine($"Os Boletos são iguais.\n-> Primeiro boleto: {firstBoleto.CodigoDocumento}\n-> Segundo boleto: {secondBoleto.CodigoDocumento}\n");
			//         else
			//             Console.WriteLine($"Os boletos são diferentes.\n-> Primeiro boleto: {firstBoleto.CodigoDocumento}\n-> Segundo boleto: {secondBoleto.CodigoDocumento}\n");

			#endregion

			//ADSEx.StartGame();

			Calculadora calc = new Calculadora();
			Console.WriteLine("Soma int: " + calc.Soma(1, 2));
			Console.WriteLine("Soma float: " + calc.Soma(3.3, 4.4));
			Console.WriteLine("Soma double: " + calc.Soma(32.43, 543.534));
			Console.WriteLine("Soma int: " + calc.Soma(1, 3, 5));
			Console.WriteLine("Soma float: " + calc.Soma(1.2, 2.3, 5.4));
			Console.WriteLine("Soma double: " + calc.Soma(1.5, 2.5, 3.5) + "\n");

			Relogio rel = new Relogio();
			rel.ConfiguraHorario(1, 3);
			rel.ConfiguraHorario(3, 6, 9);

			ThirdCar car = new ThirdCar();
			car.MontaCarro("Civic", "Honda", 3312);
			car.MontaCarro("Civic", "Honda");
			car.MontaCarro("Civic", 3312);

			Console.ReadLine();
		}
	}
}
