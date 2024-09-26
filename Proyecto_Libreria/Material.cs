using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    public abstract class Material
    {
        public string Titulo { get; set; }
        public bool Disponible { get; set; }

        public Material (string titulo)
        {
            Titulo = titulo;
            Disponible = true;
        }

        public abstract void Prestar();
        public abstract void Devolver();
    }
}
