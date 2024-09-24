using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    public class Revista : Material
    {
        public int Edicion { get; set; }

        public Revista (string titulo, int edicion) : base(titulo)
        {
            Edicion = edicion;
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
    }
}
