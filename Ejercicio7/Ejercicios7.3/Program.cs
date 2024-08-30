using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaDeParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un numero:"); 
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    numerosPares.Add(numero);
                }
                else
                {
                    numerosImpares.Add(numero);
                }
            }

            int sumaPares = 0;
            foreach (int numero in numerosPares)
            {
                sumaPares += numero;
            }

            int sumaImpares = 0;
            foreach (int numero in numerosImpares)
            {
                sumaImpares += numero;
            }

            Console.WriteLine($"La suma de los numeros pares son: {sumaPares}");
            Console.WriteLine($"La suma de los numeros impares son: {sumaImpares}");

            Console.ReadLine();
        }
    }
}
