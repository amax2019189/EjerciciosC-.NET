using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseGenerica
{
    public class Recolector<T>
    {
        private List<T> elementos = new List<T>();

        public void AgregarElemento(T elemento)
        {
            elementos.Add(elemento);
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en la lista:");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
