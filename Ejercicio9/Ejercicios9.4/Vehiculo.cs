using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoPuertas
{
    class Vehiculo
    {
        public int Ruedas { get; set; }
        private int Puertas { get; set; }

        public Vehiculo()
        {
            Ruedas = 4;
            Puertas = 4;
        }

        public Vehiculo(int ruedas)
        {
            Ruedas = ruedas;
            Puertas = 4;
        }

        public Vehiculo(int ruedas, int puertas)
        {
            Ruedas = ruedas;
            Puertas = puertas;
        }
        public int GetPuertas()
        {
            return Puertas;
        }

        public void SetPuertas(int puertas)
        {
            Puertas = puertas;
        }
    }
}
