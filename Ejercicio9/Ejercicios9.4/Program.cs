using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoPuertas
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();
            Console.WriteLine($"Vehículo 1: {vehiculo1.Ruedas} ruedas, {vehiculo1.GetPuertas()} puertas");

            Console.ReadLine();
        }
    }
}
