using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Proceso
    {
        public void Grafo()
        {
            Console.WriteLine("a -> b -> c -> d -> e -> f-> g");
            Console.WriteLine("a -> b -> c -> g -> f -> d-> e");
            Console.WriteLine("a -> b -> c -> g -> f -> e-> d");    // Aqui se muestran todos los caminos hechos de manera manual y de la unica manera que se por el momento
            Console.WriteLine("a -> b -> g -> c -> d -> f-> e");
            Console.WriteLine("a -> b -> g -> c -> d -> e-> f");
            Console.WriteLine("a -> b -> g -> f -> e -> d-> c");
        }
    }
}
