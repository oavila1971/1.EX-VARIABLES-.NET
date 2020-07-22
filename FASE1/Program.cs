using System;
using System.Dynamic;

namespace FASE1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Introdueix nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Introdueix primer cognom");
            string cognom1 = Console.ReadLine();
            Console.WriteLine("Introdueix segon cognom");
            string cognom2 = Console.ReadLine();

            Console.WriteLine("Introdueix dia de naixement");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix mes de naixament");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix any de naixement");
            int any = int.Parse(Console.ReadLine());


            Console.WriteLine($"Nom complet: {cognom1} {cognom2}, {nom}");
            Console.WriteLine($"Data de naixament: {dia}/{mes}/{any}");
        }
    }
}
