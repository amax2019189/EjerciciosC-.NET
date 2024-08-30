using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convertidor
            Console.WriteLine(" _______________________");
            Console.WriteLine("|      Convertidor      |");
            Console.WriteLine("|                       |");
            Console.WriteLine("| 1. De Dólares a Euros |");
            Console.WriteLine("| 2. De Euros a Dólares |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine(" ");

            Console.Write("Por favor ingrese que opción quiere convertir: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el cambio del dia: ");
                    float cambioEuro = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor que desea convertir:");
                    int num1 = int.Parse(Console.ReadLine());
                    float total = MutiplicarEuro(num1,cambioEuro);
                    Console.WriteLine("Su cambio es de: " + total);
                    break;
                case 2:
                    Console.Write("Ingrese el cambio del dia: ");
                    float cambioDolar = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor que desea convertir:");
                    int num2 = int.Parse(Console.ReadLine());
                    float totalDolar = MutiplicarDolar(num2, cambioDolar);
                    Console.WriteLine("Su cambio es de: " + totalDolar);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
            #endregion
        }

        static float MutiplicarEuro(int num1, float cambio)
        {
            return num1 * cambio;
        }

        static float MutiplicarDolar(int num2, float cambio)
        {
            return num2 * cambio;
        }
    }
}