using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.MathAlgorithms;
using Testing.POO_3.A2;
using Testing.POO_3.A4Entrega;

namespace Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            //EX: 1
            Car car = new Car();
            car.Name = "C4";
            car.Power = 120;
            Console.WriteLine(car.ToString());

            //EX: 2
            Telephone telephone = new Telephone();
            telephone.TelephoneNumber = 123456789;
            telephone.Operator = "Vivo";

            Telephone telephoneTwo = new Telephone();
            telephoneTwo.TelephoneNumber = 987654321;
            telephoneTwo.Operator = "Claro";

            List<Telephone> telephList = new List<Telephone>();
            telephList.Add(telephone);
            telephList.Add(telephoneTwo);

            foreach (var item in telephList)
            {
                if (telephList.Contains(item) || telephList.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }

            //EX: 3
            Persona person = new Persona();
            Console.WriteLine("\nInsert your name:");
            person.Name = Console.ReadLine();
            Console.WriteLine("\nInsert your age:");
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsert your adress:");
            person.Adress = Console.ReadLine();

            Persona personTwo = new Persona();
            Console.WriteLine("\nInsert your name:");
            personTwo.Name = Console.ReadLine();
            Console.WriteLine("\nInsert your age:");
            personTwo.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsert your adress:");
            personTwo.Adress = Console.ReadLine();

            List<Persona> personList = new List<Persona>();
            personList.Add(person);
            personList.Add(personTwo);

            foreach (var item in personList)
            {
                if (personList.Contains(item) || personList.Contains(item)) { Console.WriteLine(item); }
            }

            //EX: 4
            Payroll payroll = new Payroll();
            Console.WriteLine("\nInsert a name:");
            payroll.Name = Console.ReadLine();
            while (payroll.Wage <= 0)
            {
                Console.WriteLine("\nInsert a wage:");
                payroll.Wage = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nInsert a second name:");
            payroll.SecondName = Console.ReadLine();
            while (payroll.SecondWage <= 0)
            {
                Console.WriteLine("\nInsert your wage:");
                payroll.SecondWage = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nTotal folha de pagamento: " + payroll.TotalFolhaPagamento() + "\n");
            Console.WriteLine(payroll.ToString());

            //EX: 5
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Name = "Moto";
            motorcycle.Brand = "Marca";
            motorcycle.Power = 1200;
            motorcycle.Weight = 230;

            Motorcycle motorcycleTwo = new Motorcycle();
            motorcycleTwo.Name = "Yamaha";
            motorcycleTwo.Brand = "MarcaDois";
            motorcycleTwo.Power = 1500;
            motorcycleTwo.Weight = 340;

            List<Motorcycle> motorcyclesList = new List<Motorcycle>();
            motorcyclesList.Add(motorcycle);
            motorcyclesList.Add(motorcycleTwo);

            foreach (var item in motorcyclesList)
            {
                if (motorcyclesList.Contains(item) || motorcyclesList.Contains(item)) { Console.WriteLine(item); }
            }

            Console.ReadLine();
        }
    }
}
