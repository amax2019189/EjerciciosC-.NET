using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la cantidad que desesa desglosar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal importe))
        {
            DesglosarImporte(importe);
        }

        Console.ReadLine();
    }

    static void DesglosarImporte(decimal importe)
    {
        decimal[] billetesYMonedas = { 500, 100, 50, 20, 10, 5, 1, 0.50m, 0.25m, 0.10m, 0.05m };

        Console.WriteLine($"Desglose: {importe}");

        foreach (decimal valor in billetesYMonedas)
        {
            if (importe >= valor)
            {
                int cantidad = (int)(importe / valor);
                importe -= cantidad * valor;
                Console.WriteLine($"Tiene {cantidad} de {valor}");
            }
        }
    }
}