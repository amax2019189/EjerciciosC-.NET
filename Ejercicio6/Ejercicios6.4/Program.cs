using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduce el primer número: ");
            string numero1 = Console.ReadLine();

            Console.Write("Introduce el segundo número: ");
            string numero2 = Console.ReadLine();

            Console.Write("Introduce el tercer número: ");
            string numero3 = Console.ReadLine();

            Console.Write("Introduce el cuarto número: ");
            string numero4 = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append($"El primer numero introducido es el {numero1}, ");
            sb.Append($"despues han introducido el {numero2} y {numero3}, ");
            sb.Append($"y por ultimo el {numero4}");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
