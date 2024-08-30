using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablasDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de la tabla que quiere visualizar:");
            int tabla = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {Resultado(tabla, i)}");
            }

            Console.ReadLine();
        }

        static int Resultado(int tabla, int i)
        {
            return tabla * i;
        }
    }
}
