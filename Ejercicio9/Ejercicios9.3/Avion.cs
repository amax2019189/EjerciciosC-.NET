using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Avion : Vehiculo
    {
        public int MotoresNum { get; set; }

        public Avion(string marca, string modelo, int motores) : base(marca, modelo)
        {
            MotoresNum = motores;
        }

        public override void Acelerar()
        {
            Console.WriteLine("El avion esta acelerando");
        }

        public override void Frenar()
        {
            Console.WriteLine("El avion esta frenando");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Numero de Motores: {MotoresNum}");
        }
    }
}
