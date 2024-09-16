using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno("Juan", "Pérez", "1234567891011", "Ingeniería", new List<double> { 7.5, 8.0, 6.5, 7.0, 6.0 }),
                new Alumno("Ana", "García", "6789054554555", "Medicina", new List<double> { 9.0, 8.5, 7.5, 8.0, 9.0 }),
                new Alumno("Carlos", "López", "1265486535612", "Derecho", new List<double> { 5.0, 6.0, 4.5, 5.5, 6.0 }),
                new Alumno("Laura", "Martínez", "1415148965123", "Economía", new List<double> { 8.5, 7.5, 9.0, 8.0, 9.5 }),
                new Alumno("Sofia", "Gómez", "1617178924621", "Arquitectura", new List<double> { 6.0, 6.5, 6.0, 7.0, 7.5 }),
            };
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("      __________________________________ ");
                Console.WriteLine("     |                                  |");
                Console.WriteLine("     | Información de todos los alumnos |");
                Console.WriteLine("     |__________________________________|");
                Console.ResetColor();
                foreach (var alumno in alumnos)
                {
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" ____________________________________________");
                    Console.WriteLine($" Nombre Completo: {alumno.NombreCompleto()}");
                    Console.WriteLine($" Número de Identificación: {alumno.NoIdentificacion}");
                    Console.WriteLine($" Carrera: {alumno.Carrera}");
                    Console.WriteLine($" Promedio de Notas: {alumno.ObtenerPromedio():F2}");
                    Console.WriteLine(" ____________________________________________");
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("      __________________________________ ");
                Console.WriteLine("     |                                  |");
                Console.WriteLine("     |  Alumnos con Promedio mayor a 6  |");
                Console.WriteLine("     |__________________________________|");
                Console.WriteLine("");
                Console.ResetColor();
                
                foreach (var alumno in alumnos.Where(a => a.ObtenerPromedio() >= 6))
                {
                    Console.WriteLine($" Nombre Completo: {alumno.NombreCompleto()}");
                    Console.WriteLine($" Número de Identificación: {alumno.NoIdentificacion}");
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
