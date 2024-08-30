using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduce la cantidad de elementos que tendre el array: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Ingresa un numero: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array actual:");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Ingrese el nuevo numero por intrducir: ");
            int nuevoValor = int.Parse(Console.ReadLine());

            Console.Write($"Ingresa la posicion donde quieres insertar el valor (0 a {tamaño - 1}): ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion < 0 || posicion >= tamaño)
            {
                Console.WriteLine("La posición es invalida.");
                return;
            }

            int[] nuevoArray = new int[tamaño + 1];

            for (int i = 0, j = 0; i < nuevoArray.Length; i++)
            {
                if (i == posicion)
                {
                    nuevoArray[i] = nuevoValor;
                }
                else
                {
                    nuevoArray[i] = array[j];
                    j++;
                }
            }

            Console.WriteLine("Nuevo ingreso:");
            foreach (var num in nuevoArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
