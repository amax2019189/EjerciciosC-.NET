using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoSemana6
{
    class API_Services
    {
        private readonly string _filePath;
        public API_Services(string filePath)
        {
            _filePath = filePath;
            VerificarArchivo();
        }

        public void VerificarArchivo()
        {
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath))
                {
                }
                Console.WriteLine("Archivo creado: " + _filePath);
            }
        }

        public async Task<string> ChisteAleatorio()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.chucknorris.io/jokes/random");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var chiste = JsonConvert.DeserializeObject<dynamic>(responseBody);
                return chiste.value;
            }
        }
    }
}