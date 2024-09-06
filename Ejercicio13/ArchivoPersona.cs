using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class ArchivoPersona : IArchivo
    {
        private readonly string filePath = "Persona.txt";

        public void GuardarDatos(Persona persona)
        {
            string registro = $"{persona.Nombre}|{persona.Edad}|{persona.Localidad};";
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] datos = Encoding.UTF8.GetBytes(registro);
                    fs.Write(datos, 0, datos.Length);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al guardar los datos: {e.Message}");
            }
        }

        public List<Persona> LeerDatos()
        {
            List<Persona> personas = new List<Persona>();
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        byte[] datosLeidos = new byte[fs.Length];
                        fs.Read(datosLeidos, 0, datosLeidos.Length);
                        string contenido = Encoding.UTF8.GetString(datosLeidos);
                        string[] registros = contenido.Split(';');

                        foreach (var reg in registros)
                        {
                            if (!string.IsNullOrEmpty(reg))
                            {
                                string[] personaDatos = reg.Split('|');
                                personas.Add(new Persona(personaDatos[0], int.Parse(personaDatos[1]), personaDatos[2]));
                            }
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error al leer los datos: {e.Message}");
                }
            }
            return personas;
        }
    }
}