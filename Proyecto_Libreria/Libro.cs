using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    public class Libro : Material
    {
        public string Autor { get; set; }
        
        public Libro (string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }
        
        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($" El libro '{Titulo}' ha sido prestado");
            }
            else
            {
                Console.WriteLine($" El libro '{Titulo}' no esta disponible");
            }
        }

        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($" El libro '{Titulo}' ha sido devuelto");
            }
            else
            {
                Console.WriteLine($" El libro '{Titulo}' esta disponible");
            }
        }
    }
}
