using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese un nombre:");
                string nombres = Console.ReadLine();

                Console.Write("Ingrese su edad:");
                int edad = int.Parse(Console.ReadLine());

                persona.Add(new Persona(nombres, edad));
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los Mayores de edad son:");

            foreach (var mayor in persona)
            {
                if (mayor.Edad >= 18)
                {
                    Console.WriteLine(mayor.Nombre);
                }
            }

            Console.ReadLine();
        }
    }
}
