using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  _______________________");
            Console.WriteLine(" |      Calculadora      |");
            Console.WriteLine(" |                       |");
            Console.WriteLine(" | 1. Suma               |");
            Console.WriteLine(" | 2. Resta              |");
            Console.WriteLine(" | 3. Mutiplicación      |");
            Console.WriteLine(" | 4. División           |");
            Console.WriteLine(" | 5. Salir              |");
            Console.WriteLine(" |_______________________|");
            Console.WriteLine(" ");

            Console.Write("Por favor ingrese que opción quiere realizar: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer numero: ");
                    float num1 = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    float num2 = float.Parse(Console.ReadLine());

                    float totalSuma = Suma(num1, num2);
                    Console.WriteLine("El resultado de la suma es: " + totalSuma);
                    break;
                case 2:
                    Console.Write("Ingrese el primer numero: ");
                    float num3 = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    float num4 = float.Parse(Console.ReadLine());

                    float totalResta = Resta(num3, num4);
                    Console.WriteLine("El resultado de la resta es: " + totalResta);
                    break;
                case 3:
                    Console.Write("Ingrese el primer numero: ");
                    float num5 = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    float num6 = float.Parse(Console.ReadLine());

                    float totalMultiplicacion = Multiplicacion(num5, num6);
                    Console.WriteLine("El resultado de la multiplicacion es: " + totalMultiplicacion);
                    break;
                case 4:
                    Console.Write("Ingrese el primer numero: ");
                    float num7 = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    float num8 = float.Parse(Console.ReadLine());

                    if (num7 == 0 || num8 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    else
                    {
                        float totalDivision = Division(num7, num8);
                        Console.WriteLine("El resultado de la division es: " + totalDivision);
                    }
                    break;
                default:
                    Console.WriteLine("Cerrando el programa. ¡Hasta luego!");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }

            Console.ReadLine();
        }

        static float Suma(float num1, float num2)
        {
            return num1 + num2 ;
        }

        static float Resta(float num3, float num4)
        {
            return num3 - num4;
        }
        static float Multiplicacion(float num5, float num6)
        {
            return num5 * num6;
        }
        static float Division(float num7, float num8)
        {
            return num7 / num8;
        }
    }
}