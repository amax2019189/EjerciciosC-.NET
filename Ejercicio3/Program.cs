using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre:");

            string nombre = Console.ReadLine();
            
            Console.WriteLine("Hola " + nombre);
            
            Console.ReadKey();

            Console.WriteLine("Introduce una Ciudad:");

            string nombreCity = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " Bienvenido a " + nombreCity);

            Console.ReadKey();
        }
    }
}
