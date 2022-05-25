using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string d;
            do
            {
                Console.WriteLine("Wpisz 1 liczbę:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wpisz 2 liczbę:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj działanie(+, -, *, /, NWD, z - zakończ):");
                d = Console.ReadLine();
                switch (d)
                {
                    case "+":
                        Matma.dodawanie(a,b);
                        break;
                    case "-":
                        Matma.odejmowanie(a, b);
                        break;
                    case "*":
                        Matma.mnozenie(a, b);
                        break;
                    case "/":
                        Matma.dzielenie(a, b);
                        break;
                    case "NWD":
                        Matma.nwd(a, b);
                        break;
                    case "^":
                        Matma.potega(a, b);
                        break;
                    case "v":
                        Matma.pierwiastek(a, b);
                        break;
                }
            } while (d!="z");
        }
    }
    public static class Matma
    {
        public static void dodawanie(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, c);
        }
        public static void odejmowanie(double a, double b)
        {
            double c = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, c);
        }
        public static void mnozenie(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, c);
        }
        public static void dzielenie(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("{0}/{1}={2}",a, b, c);
        }
        public static void nwd(double a, double b)
        {
            double x = a;
            double y = b;
            while(a!=b)
            {
                if(a>b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("NWD({0},{1})={2}",x,y,a);
        }
        public static void potega(double a, double b)
        {
            double c = Math.Pow(a,b);
            Console.WriteLine("{0}^{1}={2}", a, b, c);
        }
        public static void pierwiastek(double a, double b)
        {
            Console.WriteLine("pierwiastek z a: " + Math.Sqrt(a));
            Console.WriteLine("pierwiastek z b: " + Math.Sqrt(b));
        }
    }

}
