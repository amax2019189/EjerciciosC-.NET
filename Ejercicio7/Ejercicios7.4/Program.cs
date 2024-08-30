using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosMayoresMenores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            int numeroMax = numeros.Max();
            int numeroMin = numeros.Min();

            Console.WriteLine($"El numero Mayor es: {numeroMax}");
            Console.WriteLine($"El numero Menor es: {numeroMin}");

            Console.ReadLine();
        }
    }
}
