using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            string carpeta = "JugadoresGuardados";

            List<Jugador> jugadores = new List<Jugador>
            {
                new Jugador("Alejandro", 15, 100, 2),
                new Jugador("Benjamin", 20, 120, 3),
                new Jugador("Max", 10, 80, 1),
                new Jugador("Lopez", 25, 150, 4)
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Quieres agregar un nuevo Jugador (S/N): ");
            Console.ResetColor();
            string respuesta = Console.ReadLine().ToLower();

            while (respuesta == "s")
            {
                Console.WriteLine("");
                Console.Write(" Ingrese el Nombre del jugador: ");
                string nombre = Console.ReadLine();

                Jugador jugadorExistente = jugadores.FirstOrDefault(j => j.Nombre == nombre);

                if (jugadorExistente != null)
                {
                    Console.WriteLine("");
                    Console.Write(" Ya existe un jugador con ese nombre. Desea editar (E) o crear un nuevo jugador (N): ");
                    string accion = Console.ReadLine().ToLower();

                    if (accion == "e")
                    {
                        Console.Write(" Ingrese el Nivel del jugador: ");
                        jugadorExistente.Nivel = int.Parse(Console.ReadLine());

                        Console.Write(" Ingrese los Puntos de Vida del jugador: ");
                        jugadorExistente.PuntosDeVida = int.Parse(Console.ReadLine());

                        Console.Write(" Ingrese el Numero de Reinicios del jugador: ");
                        jugadorExistente.NumeroDeReinicios = int.Parse(Console.ReadLine());

                        jugadorExistente.GuardarProgreso(carpeta);
                        Console.WriteLine(" Jugador editado exitosamente");
                    }
                    else if (accion == "n")
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Por favor, ingrese un nombre diferente para el nuevo jugador");
                        Console.Write(" Ingrese un nuevo nombre de jugador: ");
                        nombre = Console.ReadLine();

                        Console.Write(" Ingrese el Nivel del jugador: ");
                        int nivel = int.Parse(Console.ReadLine());

                        Console.Write(" Ingrese los Puntos de Vida del jugador: ");
                        int puntosDeVida = int.Parse(Console.ReadLine());

                        Console.Write(" Ingrese el Numero de Reinicios del jugador: ");
                        int numerDeReinicios = int.Parse(Console.ReadLine());

                        Jugador nuevoJugador = new Jugador(nombre, nivel, puntosDeVida, numerDeReinicios);
                        jugadores.Add(nuevoJugador);
                        nuevoJugador.GuardarProgreso(carpeta);
                    }
                }
                else
                {
                    Console.Write(" Ingrese el Nivel del jugador: ");
                    int nivel = int.Parse(Console.ReadLine());

                    Console.Write(" Ingrese los Puntos de Vida del jugador: ");
                    int puntosDeVida = int.Parse(Console.ReadLine());

                    Console.Write(" Ingrese el Numero de Reinicios del jugador: ");
                    int numeroDeReinicios = int.Parse(Console.ReadLine());

                    Jugador nuevoJugador = new Jugador(nombre, nivel, puntosDeVida, numeroDeReinicios);
                    jugadores.Add(nuevoJugador);
                    nuevoJugador.GuardarProgreso(carpeta);
                    Console.WriteLine(" Jugador agregado exitosamente");
                }

                Console.WriteLine(" Jugador agregado Exitosamente");
                Console.WriteLine("");
                Console.Write(" Quieres agregar un nuevo Jugador (S/N): ");
                respuesta = Console.ReadLine().ToLower();
            }

            Console.WriteLine("");
            List<Jugador> jugadoresCargados = Jugador.CargarTodosLosJugadores(carpeta);
            
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" | JUGADORES GUARDADOS |");
            Console.ResetColor();
            Console.WriteLine("");

            foreach (var jugador in jugadoresCargados)
            {
                Console.WriteLine($" Jugador: {jugador.Nombre}");
                Console.WriteLine($" Nivel: {jugador.Nivel}");
                Console.WriteLine($" Puntos de Vida: {jugador.PuntosDeVida}");
                Console.WriteLine($" Número de Reinicios: {jugador.NumeroDeReinicios}\n");
            }

            Console.ReadLine();
        }
    }
}