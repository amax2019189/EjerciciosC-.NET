using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    public class Biblioteca : IBiblioteca
    {
        private List<Material> materiales = new List<Material>();

        public void AgregarMaterial(Material material)
        {
            materiales.Add(material);
            Console.WriteLine($" El material '{material.Titulo}' ha sido agregado correctamente");
        }

        public List<Material> BuscarPorTitulo(string titulo)
        {

            titulo = titulo.Trim();

            if (string.IsNullOrWhiteSpace(titulo) || titulo.Length < 2)
            {
                Console.WriteLine(" Debes ingresar al menos dos caracteres para realizar una busqueda");
                return new List<Material>();
            }

            var resultados = materiales.Where(m => m.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine($" No se encontraron materiales con el titulo: {titulo}");
            }
            return resultados;
        }

        public void PrestarMaterial(Material material)
        {
            material.Prestar();
        }

        public void DevolverMaterial(Material material)
        {
            material.Devolver();
        }
    }
}