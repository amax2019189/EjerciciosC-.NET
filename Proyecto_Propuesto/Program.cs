using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CálculoDeCuentaConPropinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese el valor a pagar: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el % de la propina que desea agregar: ");
            int porcentajePropina = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de personas con las que pagara: ");
            int personas = int.Parse(Console.ReadLine());

            double propina = monto * porcentajePropina / 100;
            double totalConPropina = monto + propina;

            String montoLetras = NumeroLetra((int)totalConPropina);

            double montoPorPersona = totalConPropina / personas;

            DateTime fechaHora = DateTime.Now;

            Console.WriteLine("  ___________________________________________ ");
            Console.WriteLine("                    FACTURA                   ");
            Console.WriteLine("");
            Console.WriteLine($"   FECHAS Y HORA          {fechaHora}");
            Console.WriteLine("");
            Console.WriteLine($"   TOTAL                  {monto:C}");
            Console.WriteLine($"   PROPINA ({porcentajePropina}%)           {propina:C}");
            Console.WriteLine($"   TOTAL CON PROPINA      {totalConPropina:C}");
            Console.WriteLine($"   MONTO POR PERSONA      {montoPorPersona:C}");
            Console.WriteLine($"   MONTO EN LETRAS        {montoLetras}");
            Console.WriteLine("  ___________________________________________ ");

            Console.ReadLine();
        }

        public static string NumeroLetra(int numero)
        {
            if (numero == 0)
                return "cero";

            if (numero < 10)
                return Unidades[numero];

            if (numero < 20)
                return Especiales[numero - 10];

            if (numero < 100)
            {
                int decena = numero / 10;
                int unidad = numero % 10;
                if (unidad == 0)
                    return Decenas[decena];
                return $"{Decenas[decena]} y {Unidades[unidad]}";
            }

            if (numero < 1000)
            {
                int centena = numero / 100;
                int resto = numero % 100;
                if (resto == 0)
                    return $"{Centenas[centena]}";
                return $"{Centenas[centena]} {NumeroLetra(resto)}";
            }

            if (numero == 1000)
                return "mil";

            return "número demasiado grande para convertir";
        }

        static readonly string[] Unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        static readonly string[] Decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        static readonly string[] Especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        static readonly string[] Centenas = { "", "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
    }
}