using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesorAlumno
{
    public class Profesor : Persona
    {
        public string Materia { get; set; }

        public Profesor (String materia)
        {
            Materia = materia;
        }
    }
}
