using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana6
{
    class Program
    {
        enum Menu
        {
            NuevoChiste,
            BuscarChiste,
            Salir
        }

        static async Task Main(string[] args)
        {
            string filePath = "Chiste.txt";
            Chistes chisteRandom = new Chistes(filePath);
            bool correr = true;

            while (correr)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("  _________________________");
                Console.WriteLine("       Menu Principal      ");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("  1. Nuevo Chiste");
                Console.WriteLine("  2. Buscar Chiste");
                Console.WriteLine("  3. Salir");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" _________________________");
                Console.ResetColor();
                Console.Write(" Ingrese una opcion: ");

                string respuesta = Console.ReadLine();
                Menu seleccionar;

                switch (respuesta)
                {
                    case "1":
                        seleccionar = Menu.NuevoChiste;
                        break;
                    case "2":
                        seleccionar = Menu.BuscarChiste;
                        break;
                    case "3":
                        seleccionar = Menu.Salir;
                        break;
                    default:
                        Console.WriteLine(" Esta opcion no es valida");
                        continue;
                }

                switch (seleccionar)
                {
                    case Menu.NuevoChiste:
                        string chiste = await chisteRandom.ChisteAleatorio();
                        if (!chisteRandom.ChisteDuplicado(chiste))
                        {
                            chisteRandom.GuardarChiste(chiste);
                            Console.WriteLine(" Chiste guardado...");
                        }
                        else
                        {
                            Console.WriteLine(" El chiste ya existe en el archivo");
                        }
                        break;

                    case Menu.BuscarChiste:
                        Console.Write(" Ingrese una palabra clave: ");
                        string resp = Console.ReadLine();
                        chisteRandom.BuscarChiste(resp);
                        break;

                    case Menu.Salir:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Saliendo del programa.....");
                        Console.ResetColor();
                        await Task.Delay(1000);
                        correr = false;
                        break;
                }

            }
        }
    }
}