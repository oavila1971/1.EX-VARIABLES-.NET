using System;

namespace FASE3
{
    class Program
    {
        static void Main(string[] args)
        {
            var anyIni = 1948;
            var anyNaix = 1971;
            const int freqTrasp = 4;
            bool esTrasp;
            var cadSiTrasp = "El meu any de naixement SÍ és de traspàs";
            var cadNoTrasp = "El meu any de naixement NO és de traspàs";
            var nom = "Òscar Àvila Castilla";
            var dataNaix = "18/02/" + anyNaix;
            string resposta;

            esTrasp = false;
            

            for (int i = anyIni; i <= anyNaix; i++)
            {
                
                if (i % freqTrasp == 0)
                {
                    Console.WriteLine("Any traspàs: " + i);
                    esTrasp = true;
                }

                esTrasp = false;


            }

            if (esTrasp == true)
            {
                resposta = cadSiTrasp;
            }
            else 
            {
                resposta = cadNoTrasp;
            }
            Console.WriteLine("El meu nom és: " + nom);
            Console.WriteLine("Vaig néixer el dia " + dataNaix);
            Console.WriteLine(resposta);
        }
    }
}
