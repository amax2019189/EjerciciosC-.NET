using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoPromedio
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NoIdentificacion { get; set; }
        public string Carrera { get; set; }
        public List<double> Notas { get; set; }

        public Alumno(string nombre, string apellido, string noIdentificacion, string carrera, List<double> notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            NoIdentificacion = noIdentificacion;
            Carrera = carrera;
            Notas = notas;
        }

        public double ObtenerPromedio()
        {
            return Notas.Average();
        }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
