using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    internal class Program
    {
        static double Osszeadas(double elsoszam,  double masodikszam)
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
            return (elsoszam/masodikszam)*100;
        }
        static void Indit()
        {
            Console.Write("Kérem adja meg az első számot: ");
            double elsoszam = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            double masodikszam = double.Parse(Console.ReadLine());
            Console.Write("Az elvégezendő művelet jele: ");
            char muvelet = char.Parse(Console.ReadLine());
            if (muvelet == '+')
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Osszeadas(elsoszam, masodikszam)}");

            }
            else if (muvelet == '-')
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Kivonas(elsoszam, masodikszam)}");
            }
            else if (muvelet == '*')
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Szorzas(elsoszam, masodikszam)}");
            }
            else if (muvelet == '/')
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Osztas(elsoszam, masodikszam)}");
            }
            else if (muvelet == '%')
            {
                Console.WriteLine($"{elsoszam} {muvelet} {masodikszam} = {Szazalek(elsoszam, masodikszam)}");
            }
            else
            {
                Console.WriteLine("Hibás Művelet jelet adott meg");
            }
        }

        static void Main(string[] args)
        {
            Indit();
            Console.ReadKey();

        }
    }
}
