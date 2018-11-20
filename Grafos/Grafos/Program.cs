using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso proceso = new Proceso();

            Console.WriteLine("Caminos existentes: \n");
            proceso.Grafo();
            Console.ReadKey();
        }
    }
}
