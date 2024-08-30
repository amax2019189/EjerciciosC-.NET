using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Coche : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Coche(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void Acelerar()
        {
            Console.WriteLine("El coche esta acelerando");
        }

        public override void Frenar()
        {
            Console.WriteLine("El coche esta frenando");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
        }
    }
}
