using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertirPalabra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un palabra: ");
            string palabra = Console.ReadLine();

            string resultado = InvertirPalabra(palabra);
            Console.WriteLine(resultado);

            Console.ReadLine();
        }
        static string InvertirPalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
