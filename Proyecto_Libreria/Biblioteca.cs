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
            var resultados = materiales.Where(m => m.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            if (resultados.Count == 0)
            {
                Console.WriteLine($" No se encontraron materiales con el titulo: {titulo}");
            }
            return resultados;
        }

        public void PrestarMaterial(Material material)
        {
            if (material.Disponible)
            {
                material.Disponible = false;
                Console.WriteLine($" El material '{material.Titulo}' ha sido prestado");
            }
            else
            {
                Console.WriteLine($" El material '{material.Titulo}' no esta disponible");
            }
        }

        public void DevolverMaterial(Material material)
        {
            if (!material.Disponible)
            {
                material.Disponible = true;
                Console.WriteLine($" El materail '{material.Titulo}' ha sido devuelto");
            }
            else
            {
                Console.WriteLine($" El material '{material.Titulo}' esta disponible");
            }
        }
    }
}