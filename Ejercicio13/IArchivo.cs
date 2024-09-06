using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    interface IArchivo
    {
        void GuardarDatos(Persona persona);
        List<Persona> LeerDatos();
    }
}
