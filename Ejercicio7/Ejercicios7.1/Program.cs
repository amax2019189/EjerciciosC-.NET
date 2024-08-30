using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();

            for (int i = 1; i <= 1000; i++)
            {
                numeros.Add(i);
            }

            int suma = 0;

            foreach (int numero in numeros)
            {
                suma += numero;
            }
            Console.WriteLine($"La suma de los números del ArrayList es: {suma}");

            Console.ReadLine();
        }
    }
}
