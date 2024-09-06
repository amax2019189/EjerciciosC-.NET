using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class TortillaDePapa
    {
        public async Task PelarPapas()
        {
            Console.WriteLine("Pelar papas...");
            await Task.Delay(2000);
            Console.WriteLine("Papas peladas");
        }

        public async Task CortarPapas()
        {
            Console.WriteLine("Cortar Pepas...");
            await Task.Delay(2000);
            Console.WriteLine("Papas Cortadas");
        }

        public async Task BatirHuevos()
        {
            Console.WriteLine("Batir Huevos...");
            await Task.Delay(2000);
            Console.WriteLine("Huevos Batidos");
        }

        public async Task FreirPapas()
        {
            Console.WriteLine("Freir las Papas...");
            await Task.Delay(3000);
            Console.WriteLine("Papas Fritas");
        }

        public async Task CocinarTortillas()
        {
            Console.WriteLine("Cocinar Tortillas...");
            await Task.Delay(2000);
            Console.WriteLine("Torillas cocidas");
        }

        public async Task PrepararTortillasDePapa()
        {
            Task pelar = PelarPapas();
            Task cortar = CortarPapas();
            Task batir = BatirHuevos();

            await Task.WhenAll(pelar, cortar, batir);

            await FreirPapas();
            await CocinarTortillas();

            Console.WriteLine("Las tortillas estasn listas");
        }
    }
}
