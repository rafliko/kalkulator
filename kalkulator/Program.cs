﻿using System;

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
                }
            } while (d!="z");
        }
    }
}
