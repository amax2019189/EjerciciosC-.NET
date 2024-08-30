using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Suma
            var numero1 = 1;
            var numero2 = 2;
            var numero3 = 3;
            var resultadoSuma = numero1+numero2+numero3;
            Console.WriteLine(resultadoSuma);
            #endregion

            #region Mayor
            Console.WriteLine("Ingrese un numero entero:");
            int numero4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero:");
            int numero5 = int.Parse(Console.ReadLine());

            if (numero4 > numero5)
            {
                Console.WriteLine("El numero " + numero4 + " es el mayor");
            }
            else if (numero4 < numero5)
            {
                Console.WriteLine("El numero " + numero5 + " es el mayor");
            }
            else
            {
                Console.WriteLine("Los numeros ingresados son iguales");
            }
            #endregion

            #region Semana
            Console.WriteLine("Ingrese que dia es hoy:");
            String dia = Console.ReadLine().Trim().ToLower();

            switch (dia)
            {
                case "sabado":
                    Console.WriteLine("Es fin de Semana");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de Semana");
                    break;
                case "lunes":
                    Console.WriteLine("No es fin de Semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de Semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de Semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de Semana");
                    break;
                case "viernes":
                    Console.WriteLine("No es fin de Semana");
                    break;
                default:
                    Console.WriteLine("El dato ingresado no es un dia de la semana.");
                    break;
            }
            #endregion

            #region Pagos
            Console.WriteLine("Por favor ingrese el monto a pagar:");
            int producto = int.Parse(Console.ReadLine());
            Console.WriteLine("El precio del producto es de: Q  " + producto);

            Console.WriteLine("Como desae pagar su producto:");
            String formaDePago = Console.ReadLine();

            switch (formaDePago)
            {
                case "efectivo":
                    Console.WriteLine("Su pago se ha realizado exitosamente.");
                    break;
                case "tarjeta":
                    Console.WriteLine("Ingrese el numero de cuenta:");
                    int cuenta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pago exitoso");
                    Console.WriteLine("Se desconto Q." + producto + " de la cuenta " + cuenta);
                    break;
                default:
                    Console.WriteLine("No existe otra forma de pago.");
                    break;
            }
            #endregion

            #region bucle
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            
            #region bucle While
            int bucle = 1;

            while (bucle <= 100)
            {
                Console.WriteLine(bucle);
                bucle++;
            }
            #endregion
            
            #region par
            int i = 1;

            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
            #endregion
            
            #region par y divisible
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            
            #region array par
            int[] numeros = new int[80];
            int rastreo = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numeros[rastreo] = i;
                    rastreo++;
                }
            }

            Console.WriteLine("Números pares del 1 al 100:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            #endregion
            
            #region suma y resta de pares e impares
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            int resultadoFinal = sumaPares - sumaImpares;

            Console.WriteLine("Resultado final: " + resultadoFinal);
            #endregion
            
            #region Dias de la semana
            Console.WriteLine("Ingrese un numero entre 1 y 7:");
            int numerosDias = int.Parse(Console.ReadLine());

            switch (numerosDias)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("El numero sobrepasa el rango propuesto.");
                    break;
            }
            #endregion
            
            #region 1 al 1000
            int numero = 0;
            bool numeroValido = false;

            while (!numeroValido)
            {
                Console.Write("Introduce un número entre 1 y 1000: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero >= 1 && numero <= 1000)
                {
                    numeroValido = true;
                }
                else
                {
                    Console.WriteLine("Número no válido. Debe ser un número entero entre 1 y 1000.");
                }
            }

            int suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            double media = suma / (double)numero;

            Console.WriteLine($"La suma de los números del 1 al {numero} es: {suma}");
            Console.WriteLine($"La media de los números del 1 al {numero} es: {media}");
            #endregion
            
            #region Primo
            Console.WriteLine("Introduce un número: ");
            int numeroIntroducido = int.Parse(Console.ReadLine());

            if (EsPrimo(numeroIntroducido))
            {
                Console.WriteLine($"{numeroIntroducido} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numeroIntroducido} no es un número primo.");
            }

            bool EsPrimo(int numero)
            {
                if (numero <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                        return false;
                }

                return true;
            }
            #endregion
            */
            #region Cifras
            Console.WriteLine("Introduce un número entero positivo: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero) && numero > 0)
            {
                int cantidadCifras = ContarCifras(numero);
                Console.WriteLine($"El número {numero} tiene {cantidadCifras} cifras.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero positivo.");
            }

            int ContarCifras(int num)
            {
                int contador = 0;

                while (num > 0)
                {
                    num /= 10;
                    contador++;
                }

                return contador;
            }
            #endregion
            Console.Read();
        }
    }
}