using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letrasDeA_Z
{
    class Program
    {
        static void Main()
        {
            char letra = 'Z';
            while (letra >= 'A')
            {
                Console.WriteLine(letra + " ");
                letra--;
            }

            Console.ReadLine();
        }
    }
}