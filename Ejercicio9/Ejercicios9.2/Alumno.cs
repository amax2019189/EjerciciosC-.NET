using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesorAlumno
{
    public class Alumno : Persona
    {
        public int Numero { get; set; }

        public Alumno (int numero)
        {
            Numero = numero;
        }
    }
}
