using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("El vehiculo esta acelerando");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("El vehiculo esta frenando");
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}
