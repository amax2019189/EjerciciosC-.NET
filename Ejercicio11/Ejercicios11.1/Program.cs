using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            int numero;
            string cadena;

            do
            {
                Console.Write("Ingresa un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    Console.Write("Ingresa una cadena: ");
                    cadena = Console.ReadLine();

                    diccionario[numero] = cadena;
                }

            } while (numero != 0);

            string cadena2;
            do
            {
                Console.Write("Ingresa una cadena de 2 letras: ");
                cadena2 = Console.ReadLine();
            } while (cadena2.Length != 2);

            var clavesConCadena = diccionario.Where(kvp => kvp.Value.Contains(cadena2)).Select(kvp => kvp.Key).ToList();

            if (clavesConCadena.Count > 0)
            {
                Console.WriteLine("Claves que contienen la cadena \"{0}\":", cadena2);
                foreach (var clave in clavesConCadena)
                {
                    Console.WriteLine(clave);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron claves que contengan la cadena \"{0}\".", cadena2);
            }

            Console.ReadLine();
        }
    }
}
