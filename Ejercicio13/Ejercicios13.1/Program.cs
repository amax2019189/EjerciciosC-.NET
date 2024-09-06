using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            IArchivo archivo = new ArchivoPersona();
            bool terminar = true;

            while (terminar)
            {
                Console.WriteLine("Desea agregar un nombre? (S/N):");
                string respuesta = Console.ReadLine().ToUpper();

                if (respuesta == "S")
                {
                    string nombre = ObtenerNombre();
                    int edad = ObtenerEdad();
                    string localidad = ObtenerLocalidad();

                    Persona persona = new Persona(nombre, edad, localidad);
                    archivo.GuardarDatos(persona);
                }
                else if (respuesta == "N")
                {
                    terminar = false;
                }
                else
                {
                    Console.WriteLine("La respuesta ingresada no es valida");
                }
            }

            Console.WriteLine("| PERSONAS INGRESADAS|");
            List<Persona> personas = archivo.LeerDatos();

            if (personas.Count > 0)
            {
                foreach (var per in personas)
                {
                    Console.WriteLine(per);
                }
            }
            else
            {
                Console.WriteLine("No hay datos en el documento");
            }

            Console.ReadLine();
        }

        static string ObtenerNombre()
        {
            string nombre;
            do
            {
                Console.WriteLine("Por favor ingrese su nombre: ");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre));
            {
                return nombre;
            }
        }

        static int ObtenerEdad()
        {
            int edad;
            do
            {
                Console.WriteLine("Por favor ingrese su edad: ");
            } while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0);
            {
                return edad;
            }
        }

        static string ObtenerLocalidad()
        {
            string localidad;
            do
            {
                Console.WriteLine("Por favor ingrese su localidad: ");
                localidad = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(localidad));
            {
                return localidad;
            }
        }
    }
}