using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesorAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un nombre:");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su rol (Alumno - Profesor): ");
            string rol = Console.ReadLine().ToLower();

            if (rol == "alumno")
            {
                Console.Write("Ingrese el numero de alumno:");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"{nombre} es un alumno, con numero de estudiante: {numero}");
            }
            if (rol == "profesor")
            {
                Console.Write("Ingrese la materia que imparte: ");
                string materia = Console.ReadLine();

                Console.WriteLine($"{nombre}, La materia que usted imparte es: {materia}");
            }

            Console.ReadLine();
        }
    }
}
