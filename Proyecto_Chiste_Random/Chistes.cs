using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoSemana6
{
    class Chistes
    {
        private readonly string _filePath;

        public Chistes(string filePath)
        {
            _filePath = filePath;
        }

        public bool ChisteDuplicado(string chiste)
        {
            if (File.Exists(_filePath))
            {
                var chistes = File.ReadAllLines(_filePath);
                foreach (var line in chistes)
                {
                    if (line.Equals(chiste, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public void GuardarChiste(string chiste)
        {
            int numeroChiste = Contador();
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{numeroChiste}. {chiste}");
            }
        }

        private int Contador()
        {
            if (File.Exists(_filePath))
            {
                var chistes = File.ReadAllLines(_filePath);
                return chistes.Length + 1;
            }
            return 1;
        }

        public void BuscarChiste(string palabraClave)
        {
            if (File.Exists(_filePath))
            {
                var chistes = File.ReadAllLines(_filePath);
                bool encontrado = false;

                Console.WriteLine("");

                foreach (var chiste in chistes)
                {
                    if (chiste.IndexOf(palabraClave, StringComparison.OrdinalIgnoreCase) >=0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($" {chiste}");
                        Console.ResetColor();
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontraron chistes con la palabra clave " + palabraClave);
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe");
            }
        }
    }
}