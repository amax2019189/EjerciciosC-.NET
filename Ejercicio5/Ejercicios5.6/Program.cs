using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peticionDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numMax = 0;
            int numMin = 100;
            int contar = 0;

            do
            {
                numero = PedirNumero();

                if (numero != 0)
                {
                    numMax = ObtenerMaximo(numero, numMax);
                    numMin = ObtenerMinimo(numero, numMin);
                    contar++;
                }

            } while (numero !=0);

            if (contar > 0)
            {
                Mostrar(numMax, numMin, contar);
            }
            else
            {
                Console.WriteLine("Usted no ingreso un numero");
            }

            Console.ReadLine();
        }

        static int PedirNumero()
        {
            Console.Write("Introduce un numero: ");
            return int.Parse(Console.ReadLine());
        }

        static int ObtenerMaximo(int numero, int numMax)
        {
            return numero > numMax ? numero : numMax;
        }

        static int ObtenerMinimo(int numero, int numMin)
        {
            return numero < numMin ? numero : numMin;
        }

        static void Mostrar(int numMax, int numMin, int contar)
        {
            Console.WriteLine($"Numero mas alto: {numMax}");
            Console.WriteLine($"Numero mas bajo: {numMin}");
            Console.WriteLine($"La cantidad de numeros introducidos son: {contar}");
        }
    }
}
