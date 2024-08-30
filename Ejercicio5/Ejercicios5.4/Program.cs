using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorDeLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingresa un solo carácter:");
            char caracter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (EsNumero(caracter))
            {
                Console.WriteLine("El carácter ingresado es un número.");
            }
            else if (EsVocal(caracter))
            {
                Console.WriteLine("El carácter ingresado es una vocal.");
            }
            else if (EsConsonante(caracter))
            {
                Console.WriteLine("El carácter ingresado es una consonante.");
            }
            else
            {
                Console.WriteLine("El carácter ingresado no es ni una vocal, ni un número, ni una consonante.");
            }

            Console.ReadLine();
        }

        static bool EsVocal(char x)
        {
            x = char.ToLower(x);
            return x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u';
        }
        static bool EsConsonante(char x)
        {
            x = char.ToLower(x);
            return char.IsLetter(x) && !EsVocal(x);
        }
        static bool EsNumero(char x)
        {
            return x == '1' || x == '2' || x == '3' || x == '4' || x == '5' || x == '6' || x == '7' || x == '8' || x == '9';
        }
    }
}
