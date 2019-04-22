using System;
using System.Collections.Generic;

namespace MyFirstClient
{
    class Program
    {
        public static void TempConverter()
        {
            MyFirstClient.ServiceReference1.WebService1SoapClient service = new MyFirstClient.ServiceReference1.WebService1SoapClient();
            Console.WriteLine("1)\nFahrenheit to Celsius (C)");
            Console.WriteLine("Celsius to Fahrenheit (F)");
            Console.Write("Please select an option: ");
            char option = Console.ReadKey().KeyChar;
            Console.Write("\nGive me a temperature: ");
            float degrees = 0;
            try
            {
                degrees = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
                option = 'x';
            }
            degrees = service.ConvertDegrees(degrees, option);

            switch (option)
            {
                case 'F':
                    Console.WriteLine("Celsius to Fahrenheit: " + degrees.ToString("N3") + " F\u00B0");
                    break;
                case 'C':
                    Console.WriteLine("Fahrenheit to Celsius: " + degrees.ToString("N3") + " C\u00B0");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void TimeAndDate()
        {
            MyFirstClient.ServiceReference1.WebService1SoapClient service = new MyFirstClient.ServiceReference1.WebService1SoapClient();
            Console.WriteLine("\n" + "2)\n" + service.CurrentDateTime());
            Console.ReadKey();
            Console.Clear();
        }
        public static void FiveList()
        {
            MyFirstClient.ServiceReference1.WebService1SoapClient service = new MyFirstClient.ServiceReference1.WebService1SoapClient();
            var list = new List<int>();
            Console.WriteLine("\n" + "3)");
            list = service.ReturnList();
            list.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadKey();
            Console.Clear();
        }
        public static void MoneyConverter()
        {
            MyFirstClient.ServiceReference1.WebService1SoapClient service = new MyFirstClient.ServiceReference1.WebService1SoapClient();
            Console.WriteLine("4)\nEuro to Ron (R)");
            Console.WriteLine("Ron to Euro (E)");
            Console.Write("Please select an option: ");
            char option = Console.ReadKey().KeyChar;
            Console.Write("\nGive me a sum of money: ");
            float sum = 0;
            try
            {
                sum = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
                option = 'x';
            }
            sum = service.ConvertMoney(sum, option);

            switch (option)
            {
                case 'R':
                    Console.WriteLine("Euro to Ron: " + sum.ToString("N3") + " Ron");
                    break;
                case 'E':
                    Console.WriteLine("Ron to Euro: " + sum.ToString("N3") + " Euro");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            int option = 0;
            while(option != 5)
            {
                Console.WriteLine("1)Temperature Converter");
                Console.WriteLine("2)Display date and time");
                Console.WriteLine("3)Display the first 5 prime numbers");
                Console.WriteLine("4)Money Converter");
                Console.WriteLine("5)Exit");
                Console.Write("\nSelect and option: ");
                try
                {
                    option=int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Wrong type of value given!");
                }
                switch (option)
                {
                    case 1:
                        TempConverter();
                        break;
                    case 2:
                        TimeAndDate();
                        break;
                    case 3:
                        FiveList();
                        break;
                    case 4:
                        MoneyConverter();
                        break;
                    case 5:
                        option = 5;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
