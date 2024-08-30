using System;

namespace agregarFrase
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Por favor ingrese una frase: ");
                string frase = Console.ReadLine();

                if (frase.Length >= 20 && ValidacionPalabras(frase) >= 4)
                {
                    Console.WriteLine(frase);
                    Console.WriteLine($"El numero de caracteres es de: {frase.Length}");
                    Console.WriteLine(ReemplazarCaracteres(frase));
                    string fraseMayus = PasarMayusculas(frase);
                    Console.WriteLine(fraseMayus);
                    string fraseMinus = PasarMinusculas(frase);
                    Console.WriteLine(fraseMinus);
                    Console.WriteLine(frase.Remove(0, 3));
                    Console.WriteLine(frase.Substring(5, 5));
                    Console.WriteLine(frase.Split(' ').Length);
                    Console.WriteLine(frase.Split(' ')[2]);
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un frase con 20 caracteres y 4 palabras como minimo");
                }
            } while (true);

            Console.ReadLine();
        }

        static int ValidacionPalabras(string frase)
        {
            return frase.Split(' ').Length;
        }

        static string ReemplazarCaracteres(string texto)
        {
            return texto.Replace('a', 'x').Replace('A', 'X');
        }

        static string PasarMayusculas(string frase)
        {
            return frase.ToUpper();
        }

        static string PasarMinusculas(string frase)
        {
            return frase.ToLower();
        }
    }
}