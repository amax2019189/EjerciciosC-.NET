using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animales TipoDeAnimal { get; set; }

        public Animal(Animales tipoDeAnimal)
        {
            TipoDeAnimal = tipoDeAnimal;
        }
    }
}
