using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Animal
    {
        public string Tipo { get; set; }
        public string ColorPelo { get; set; }
        public bool EsDomestico { get; set; }
        public int NumeroPatas { get; set; }

        public Animal() { }

        public Animal(string tipo, string colorPelo, bool esDomestico, int numeroPatas)
        {
            Tipo = tipo;
            ColorPelo = colorPelo;
            EsDomestico = esDomestico;
            NumeroPatas = numeroPatas;
        }
    }
}
