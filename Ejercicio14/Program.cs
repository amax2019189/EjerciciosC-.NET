using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            TortillaDePapa receta = new TortillaDePapa();
            await receta.PrepararTortillasDePapa();

            Console.ReadLine();
        }
    }
}
