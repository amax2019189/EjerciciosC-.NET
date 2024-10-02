using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana5
{
    [Serializable]
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int PuntosDeVida { get; set; }
        public int NumeroDeReinicios { get; set; }

        public Jugador (string nombre, int nivel, int puntosDeVida, int numeroDeReinicios)
        {
            Nombre = nombre;
            Nivel = nivel;
            PuntosDeVida = puntosDeVida;
            NumeroDeReinicios = numeroDeReinicios;
        }

        public void GuardarProgreso(string carpeta)
        {
            try
            {
                string rutaArchivo = Path.Combine(carpeta, $"{Nombre}.dat");

                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this);
                    Console.WriteLine("");
                    Console.WriteLine($" Progreso de {Nombre} guardado correctamente");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" Error al guardar el progreso de {Nombre}.");
                RegistrarError(e);
            }
        }

        public static Jugador CargarProgreso(string rutaArchivo)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Jugador jugador = (Jugador)formatter.Deserialize(fs);
                    Console.WriteLine(" Progreso cargado correctamente");
                    return jugador;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Error al cargar el progreso");
                RegistrarError(e);
                return null;
            }
        }

        public static List<Jugador> CargarTodosLosJugadores(string carpeta)
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                if (Directory.Exists(carpeta))
                {
                    string[] archivos = Directory.GetFiles(carpeta, "*.dat");

                    foreach (string archivo in archivos)
                    {
                        using (FileStream fs = new FileStream(archivo, FileMode.Open))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            Jugador jugador = (Jugador)formatter.Deserialize(fs);
                            jugadores.Add(jugador);
                        }
                    }

                    Console.WriteLine($" {jugadores.Count} jugadores cargados exitosamente");
                }
                else
                {
                    Console.WriteLine(" La carpeta no existe");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al cargar los jugadores");
                RegistrarError(ex);
            }

            return jugadores;
        }

        private static void RegistrarError(Exception e)
        {
            Console.WriteLine("Registrando error...");
            string rutaLog = "recolector_errores.txt";
            using (StreamWriter sw = new StreamWriter(rutaLog, true))
            {
                sw.WriteLine($"{DateTime.Now}: {e.Message}");
                sw.WriteLine(e.StackTrace);
            }
        }
    }
}