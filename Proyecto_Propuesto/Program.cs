using System;
using System.Globalization;

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

            string montoLetras = NumeroALetras(totalConPropina);

            double montoPorPersona = Math.Floor(totalConPropina / personas * 100) / 100;
            double resto = Math.Round(totalConPropina - (montoPorPersona * personas), 2);

            DateTime fechaHora = DateTime.Now;

            Console.WriteLine("  ___________________________________________ ");
            Console.WriteLine("                    FACTURA                   ");
            Console.WriteLine("");
            Console.WriteLine($"   FECHAS Y HORA          {fechaHora}");
            Console.WriteLine("");
            Console.WriteLine($"   TOTAL                  {monto:C}");
            Console.WriteLine($"   PROPINA ({porcentajePropina}%)           {propina:C}");
            Console.WriteLine($"   TOTAL CON PROPINA      {totalConPropina:C}");

            for (int i = 0; i < personas; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"   MONTO POR PERSONA {i + 1}:   {montoPorPersona + resto:C}");
                }
                else
                {
                    Console.WriteLine($"   MONTO POR PERSONA {i + 1}:   {montoPorPersona:C}");
                }
            }

            Console.WriteLine($"   MONTO EN LETRAS        {montoLetras}");
            Console.WriteLine("  ___________________________________________ ");

            Console.ReadLine();
        }

        public static string NumeroALetras(double numero)
        {
            long parteEntera = (long)Math.Floor(numero);
            int parteDecimal = (int)Math.Round((numero - parteEntera) * 100);

            return $"{NumeroLetra(parteEntera)} con {parteDecimal:00}/100";
        }

        public static string NumeroLetra(long numero)
        {
            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] decenas = { "", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

            if (numero == 0) return "cero";
            if (numero == 100) return "cien";
            if (numero == 1000) return "mil";

            string resultado = "";

            if (numero >= 100)
            {
                long centena = numero / 100;
                resultado += centenas[centena];
                numero %= 100;

                if (numero > 0) resultado += " ";
            }

            if (numero > 0 && numero < 20)
            {
                resultado += unidades[numero];
            }
            else if (numero >= 20)
            {
                long decena = numero / 10;
                resultado += decenas[decena];
                numero %= 10;

                if (numero > 0) resultado += " y " + unidades[numero];
            }

            return resultado;
        }
    }
}