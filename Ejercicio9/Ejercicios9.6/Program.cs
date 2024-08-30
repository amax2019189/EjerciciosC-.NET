using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();

            perro.Tipo = "Perro";
            perro.ColorPelo = "Marrón";
            perro.EsDomestico = true;
            perro.NumeroPatas = 4;

            Console.WriteLine($"Tipo: {perro.Tipo}");
            Console.WriteLine($"Color del Pelo: {perro.ColorPelo}");
            Console.WriteLine($"¿Es doméstico?: {perro.EsDomestico}");
            Console.WriteLine($"Número de Patas: {perro.NumeroPatas}");

            Console.ReadLine();
        }
    }
}
