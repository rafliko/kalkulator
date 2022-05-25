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
                        Console.WriteLine("pierwiastek z a: "+Math.Sqrt(a));
                        Console.WriteLine("pierwiastek z b: " + Math.Sqrt(b));
                        break;
                }
            } while (d!="z");
        }
    }
    class Matma
    {
        public void dodawanie(double a, double b)
        {

        }
        public void odejmowanie(double a, double b)
        {

        }
        public void mnozenie(double a, double b)
        {

        }
        public void dzielenie(double a, double b)
        {

        }
        public void nwd(double a, double b)
        {

        }
        public void potega(double a, double b)
        {

        }
    }

}
