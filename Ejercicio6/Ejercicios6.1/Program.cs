using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "alejandro")
            {
                Console.WriteLine($"Hola {nombre}");
            }
            else
            {
                Console.WriteLine($"{nombre}, No te conozco");
            }

            Console.ReadLine();
        }
    }
}
