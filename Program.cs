using System;

namespace Szamologep
{
    internal class Program
    {
        static double Osszeadas(double elsoszam, double masodikszam)
        {
            return elsoszam + masodikszam;
        }
        static double Kivonas(double elsoszam, double masodikszam)
        {
            return elsoszam - masodikszam;
        }
        static double Osztas(double elsoszam, double masodikszam)
        {
            return elsoszam / masodikszam;
        }
        static double Szorzas(double elsoszam, double masodikszam)
        {
            return elsoszam * masodikszam;
        }
        static double Szazalek(double elsoszam, double masodikszam)
        {
            return (elsoszam / masodikszam) * 100;
        }
        static double Gyok(double elsoszam)
        {
            return Math.Sqrt(elsoszam);
        }

        static void Indit()
        {
            Console.Write("Kérem adja meg az első számot: ");
            double elsoszam = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            double masodikszam = double.Parse(Console.ReadLine());
            Console.Write("Az elvégezendő művelet jele: ");
            string muvelet = Console.ReadLine();  // Most már string típusú, hogy kezelje a szöveges parancsokat

            if (muvelet == "+")
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Osszeadas(elsoszam, masodikszam)}");
            }
            else if (muvelet == "-")
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Kivonas(elsoszam, masodikszam)}");
            }
            else if (muvelet == "*")
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Szorzas(elsoszam, masodikszam)}");
            }
            else if (muvelet == "/")
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Osztas(elsoszam, masodikszam)}");
            }
            else if (muvelet == "%")
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Szazalek(elsoszam, masodikszam)}");
            }
            else if (muvelet.ToLower() == "sqrt")
            {
                Console.WriteLine($"√{elsoszam} = {Gyok(elsoszam)}");
                Console.WriteLine($"√{masodikszam} = {Gyok(masodikszam)}");
            }
            else
            {
                Console.WriteLine("Hibás művelet jelet adott meg");
            }
        }

        static void Main(string[] args)
        {
            Indit();
            Console.ReadKey();
        }
    }
}
