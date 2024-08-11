using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://dotnet.microsoft.com/es-es/languages/csharp
/* para crear
 * varios
 * comentarios */

namespace Proyecto_HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Entero = 7;
            Entero = Entero + 3;
            Console.WriteLine(Entero);

            double Decimal = 5.6;
            Console.WriteLine(Decimal);

            float DecimalF = 5.6f;
            Console.WriteLine(DecimalF);

            bool Igualdad = true;
            Igualdad = false;
            Console.WriteLine(Igualdad);

            dynamic Dato = 6 + 6;
            Console.WriteLine(Dato + Entero);

            var Varsito = "Es tipo inferido";
            Console.WriteLine(Varsito);

            const String Pansito = "Mi Constante";
            Console.WriteLine(Pansito);

            var Estructura = new String[] { "Benny", "Hans", "BlackTanatos" };
            Console.WriteLine(Estructura[2]);

            Estructura[2] = "36";
            Console.WriteLine(Estructura[2]);

            var Diccionario = new Dictionary<string, int>
            {
                {"BlackTanatos", 23},
                {"Oscar", 24},
                {"Luis", 22}
            };
            Console.WriteLine(Diccionario["BlackTanatos"]);

            String lenguaje = "C#";
            Console.WriteLine($"Hola mi lenguaje {lenguaje}!!!");
            Console.ReadKey();
        }
    }
}