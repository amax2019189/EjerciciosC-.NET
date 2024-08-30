using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapaAnimales = new Dictionary<int, string>
            {
                {(int)Animales.Perro, Animales.Perro.ToString()},
                {(int)Animales.Gato, Animales.Gato.ToString()},
                {(int)Animales.Canario, Animales.Canario.ToString()},
                {(int)Animales.Caballo, Animales.Caballo.ToString()}
            };

            while (true)
            {
                Console.Write("Ingrese un numero o escriba salir: ");
                string input = Console.ReadLine().ToLower();

                if (input == "salir")
                    break;

                if (int.TryParse(input, out int numero))
                {
                    if (mapaAnimales.TryGetValue(numero, out string nombreAnimal))
                    {
                        Console.WriteLine($"Ese valor pertenece al {nombreAnimal.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("No hay ningun animal asociado con ese valor");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un numero valido");
                }
            }
        }
    }
}
