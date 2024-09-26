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

        public override void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($" La revista '{Titulo}' ha sido prestado");
            }
            else
            {
                Console.WriteLine($" La revista '{Titulo}' no esta disponible");
            }
        }

        public override void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($" La revista '{Titulo}' ha sido devuelto");
            }
            else
            {
                Console.WriteLine($" La revista '{Titulo}' esta disponible");
            }
        }
    }
}
