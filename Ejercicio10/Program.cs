using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal
            {
                Tipo = "Perro",
                ColorPelo = "Negro",
                EsDomestico = true,
                NumeroPatas = 4
            };

            animal.Andar();
            if (animal.EsPerro())
            {
                Console.WriteLine("Este animal es un perro.");
            }
            else
            {
                Console.WriteLine("Este animal no es un perro.");
            }
            animal.Saltar();

            Console.ReadLine();
        }
    }
}
