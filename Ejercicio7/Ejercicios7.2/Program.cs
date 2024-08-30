using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cincoNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nombres = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese un nombre:");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);
            }

            Console.WriteLine("Ingrese el nombre por buscar:");
            String nombreBuscar = Console.ReadLine();

            if (nombres.Contains(nombreBuscar))
            {
                Console.WriteLine($"El nombre {nombreBuscar} se encuentra en la lista");
            }
            else
            {
                Console.WriteLine($"El nombre {nombreBuscar} no se encuentra en la lista");
            }

            Console.ReadLine();
        }
    }
}
