using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constantes");
            Console.WriteLine();

            const string Empresa = "Acme"; //Define y asigna el valor de la constante.
            const byte HorasLaborales = 40;

            Console.WriteLine("Empresa: {0}. Horas laborables: {1}", Empresa, HorasLaborales);
            Console.WriteLine();

            Console.WriteLine("Pulse una tecla para terminar...");
            Console.ReadKey();
        }
    }
}