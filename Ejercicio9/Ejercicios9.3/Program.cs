using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Toyota", "Corolla", 4);
            coche.MostrarInformacion();
            coche.Acelerar();
            coche.Frenar();

            Barco barco = new Barco("Yamaha", "WaveRunner", 3.3);
            barco.MostrarInformacion();
            barco.Acelerar();
            barco.Frenar();

            Avion avion = new Avion("Boeing", "747", 4);
            avion.MostrarInformacion();
            avion.Acelerar();
            avion.Frenar();

            Console.ReadLine();
        }
    }
}
