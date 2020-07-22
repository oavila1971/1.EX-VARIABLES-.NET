using System;

namespace FASE2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ANY1948 = 1948;
            var freqTraspas = 4;
            int numTraspas;

            Console.WriteLine("Introdueix el teu any de naixement:");
            int anyNaix = int.Parse(Console.ReadLine());

            numTraspas = (anyNaix - ANY1948) / freqTraspas;

            Console.WriteLine($"Han passat {numTraspas} anys de traspas des del teu naixement");
        }
    }
}
