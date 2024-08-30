using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Animal : IAnimal
    {
        public string Tipo { get; set; }
        public string ColorPelo { get; set; }
        public bool EsDomestico { get; set; }
        public int NumeroPatas { get; set; }

        public void Andar()
        {
            Console.WriteLine($"{Tipo} está andando.");
        }

        public bool EsPerro()
        {
            return Tipo.ToLower() == "perro";
        }

        public void Saltar()
        {
            Console.WriteLine($"{Tipo} está saltando.");
        }
    }
}
