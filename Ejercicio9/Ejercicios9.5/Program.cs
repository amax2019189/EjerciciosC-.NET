using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Producto.Sumar(5, 10);
            Console.WriteLine($"La suma de 5 y 10 es: {resultado}");

            Console.ReadLine();
        }
    }
}
