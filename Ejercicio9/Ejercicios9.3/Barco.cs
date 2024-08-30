using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Barco : Vehiculo
    {
        public double Longuitud { get; set; }

        public Barco(string marca, string modelo, double longitud) : base(marca, modelo)
        {
            Longuitud = longitud;
        }

        public override void Acelerar()
        {
            Console.WriteLine("El barco esta acelerando");
        }
        public override void Frenar()
        {
            Console.WriteLine("El barco esta frenando");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Longitud: {Longuitud}");
        }
    }
}
