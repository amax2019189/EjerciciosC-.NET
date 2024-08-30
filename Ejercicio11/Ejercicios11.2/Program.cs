using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            var recolector = new Recolector<int>();

            while (true)
            {
                Console.Write("Ingrese un numero o escriba salir: ");
                string input = Console.ReadLine().ToLower();

                if (input == "salir")
                    break;

                if (int.TryParse(input, out int numero))
                {
                    recolector.AgregarElemento(numero);
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un numero válido.");
                }
            }

            recolector.MostrarElementos();
            Console.ReadLine();
        }
    }
}
