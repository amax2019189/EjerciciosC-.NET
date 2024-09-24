using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Libro libro1 = new Libro("El Señor de los anillos", "J.R.R. Tolkien");
            Libro libro2 = new Libro("Mil leguas de viaje submarino", "Julio Verne");

            Revista revista1 = new Revista("National Geographic", 1);

            biblioteca.AgregarMaterial(libro1);
            biblioteca.AgregarMaterial(libro2);
            biblioteca.AgregarMaterial(revista1);

            Console.WriteLine("  ____________________________ ");
            Console.WriteLine(" |                            |");
            Console.WriteLine(" |     Buscar Por Titulo:     |");
            Console.WriteLine(" |____________________________|");
            Console.WriteLine("");

            var resultados = biblioteca.BuscarPorTitulo("El señor de los anillos");
            //var resultados = biblioteca.BuscarPorTitulo("Mil leguas de viaje submarino");
            //var resultados = biblioteca.BuscarPorTitulo("De la tierra a la Luna");
            
            foreach (var material in resultados)
            {
                Console.WriteLine($" Encontrado: {material.Titulo}");
            }

            Console.WriteLine("  ____________________________ ");
            Console.WriteLine(" |                            |");
            Console.WriteLine(" |    Prestar Materiales:     |");
            Console.WriteLine(" |____________________________|");
            Console.WriteLine("");

            biblioteca.PrestarMaterial(libro1); 
            biblioteca.PrestarMaterial(libro1);
            
            biblioteca.PrestarMaterial(revista1);

            Console.WriteLine("  ____________________________ ");
            Console.WriteLine(" |                            |");
            Console.WriteLine(" |    Devolver Materiales:    |");
            Console.WriteLine(" |____________________________|");
            Console.WriteLine("");

            biblioteca.DevolverMaterial(libro1);
            biblioteca.DevolverMaterial(revista1);

            Console.ReadLine();
        }
    }
}
