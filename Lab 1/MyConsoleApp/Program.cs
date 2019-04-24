using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        public static int RecursiveFibonacci(int n)
        {
            if(n==0)
            {
                return 0;
            }
            else
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
                }
            }
        }
        public static void FibonacciNumber()
        {
            int n=-1;
            Console.Write("n =  ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            if(n>=0)
            {
                Console.WriteLine("F" + n + " = " + RecursiveFibonacci(n));
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static int SimpleA()
        {
            int a = 0;
            Console.Write("a = ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            return a;
        }
        public static int SimpleB()
        {
            int b = 0;
            Console.Write("b = ");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            return b;
        }
        public static float SimpleHeight()
        {
            float height = 0;
            Console.Write("\nheight = ");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            return height;
        }
        public static int SimpleAge()
        {
            int age = 0;
            Console.Write("age = ");
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            return age;
        }
        public static void SimpleSum()
        {
            int a=SimpleA();
            int b=SimpleB();
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
        public static void SimpleDif()
        {
            int a = SimpleA();
            int b = SimpleB();
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }
        public static void SimpleDiv()
        {
            int a = SimpleA();
            int b = SimpleB();
            int rez = 0;
            try
            {
                rez = a / b;
            }
            catch(Exception)
            {
                Console.WriteLine("Operation imposible");
            }
            Console.WriteLine(a + " / " + b + " = " + rez);
        }
        public static void SimpleMul()
        {
            int a = SimpleA();
            int b = SimpleB();
            Console.WriteLine(a + " * " + b + " = " + (a * b));
        }
        public static void SimpleCalculator()
        {
            char operation = '=';
            Console.Write("operation ( + - * / ) =  ");
            try
            {
                operation = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            switch (operation)
            {
                case '+':
                    SimpleSum();
                    break;
                case '-':
                    SimpleDif();
                    break;
                case '/':
                    SimpleDiv();
                    break;
                case '*':
                    SimpleMul();
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static float ConvertDegrees(float degrees, char option)
        {
            switch (option)
            {
                case 'F':
                    degrees = (degrees * 1.8F) + 32;
                    break;
                case 'C':
                    degrees = (degrees - 32) * (0.555F);
                    break;
                default:
                    break;
            }
            return degrees;
        }
        public static void TempConverter()
        {
            Console.WriteLine("Fahrenheit to Celsius (C)");
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
            degrees = ConvertDegrees(degrees, option);

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
        public static void IdealWeight()
        {
            Console.WriteLine("Are you a man (M) or woman (W)?");
            Console.Write("Please select an option: ");
            char option = Console.ReadKey().KeyChar;
            float height = SimpleHeight();
            height = height * 100f;
            int age = SimpleAge();

            float idealWeight = 0f;
            switch (option)
            {
                case 'M':
                    idealWeight = (height - 100f) - ((height - 150f) / 4f) + ((age - 20f) / 4f);
                    Console.WriteLine("Ideal weight = " + idealWeight + "Kg");
                    break;
                case 'W':
                    idealWeight = (height - 100f) - ((height - 150f) / 2.5f) + ((age - 20f) / 6f);
                    Console.WriteLine("Ideal weight = " + idealWeight + "Kg");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void SimpleMean()
        {
            Console.WriteLine("Give me the lenght of the array");
            int n = 0;
            double aritMean = 0D;
            double geomMean = 1D;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong type of value given!");
            }
            int i;
            int[] arr = new int[n];
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                aritMean = aritMean + arr[i];
                geomMean = geomMean * arr[i];
            }
            aritMean = aritMean / n;
            geomMean = Math.Pow(geomMean, (1.0 / n));
            Console.WriteLine("Arithmetic mean: "+ aritMean);
            Console.WriteLine("Geometric mean: " + geomMean);
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            byte option = 0;
            while(option!=6)
            {
                Console.WriteLine("1)Fibonacci number");
                Console.WriteLine("2)Simple Calculator");
                Console.WriteLine("3)Temp Converter");
                Console.WriteLine("4)Ideal weight");
                Console.WriteLine("5)Arithmetic and Geometric mean");
                Console.WriteLine("6)Exit");
                Console.Write("\nPlease select an option: ");
                try
                {
                    option = byte.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong type of value given!");
                    option = 0;
                    Console.ReadKey();
                    Console.Clear();
                }
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("1)");
                        FibonacciNumber();
                        break;
                    case 2:
                        Console.WriteLine("2)");
                        SimpleCalculator();
                        break;
                    case 3:
                        Console.WriteLine("3)");
                        TempConverter();
                        break;
                    case 4:
                        Console.WriteLine("4)");
                        IdealWeight();
                        break;
                    case 5:
                        Console.WriteLine("5)");
                        SimpleMean();
                        break;
                    case 6:
                        option = 6;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}