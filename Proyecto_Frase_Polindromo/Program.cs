using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrasePalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor agrege una frase: ");
            String frase = Console.ReadLine().Replace(" ", "");

            string fraseLimpia = new string(frase
                .ToLower()
                .Where(c => char.IsLetter(c))
                .ToArray());

            String resultado = InvertirPalabra(frase);

            if (fraseLimpia == resultado)
            {
                Console.WriteLine("La palabra " + resultado + " si es palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra " + resultado + " no es palíndromo");
            }

            Console.ReadLine();
        }

        public static string InvertirPalabra(string frase)
        {
            char[] caracteres = frase.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}