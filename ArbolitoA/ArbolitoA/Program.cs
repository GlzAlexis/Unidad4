using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolitoA
{
    class Program
    {
        static void Main(string[] args)
        {
            Despliegue Arbolitos = new Despliegue();               //Se llama al metodo para empezar a desplegar los arboles
            Console.Write("\n~~~ Arboles chidos perrones ~~~\n");
            Console.Write("\n~~~ nArbolito A ~~~\n"); Arbolitos.ArbolitoA();
            Console.Write("\nPresione la tecla enter para pasar al siguiente arbolito chido"); Console.ReadKey(); Console.Clear();
            Console.Write("\n~~~ Arboles chidos perrones ~~~\n\n~~~ nArbolito B ~~~\n"); Arbolitos.ArbolitoB();
            Console.Write("\nPresione la tecla enter para pasar al siguiente arbolito chido"); Console.ReadKey(); Console.Clear();
            Console.Write("\n~~~ Arboles chidos perrones ~~~\n\n~~~ nArbolito C ~~~\n"); Arbolitos.ArbolitoC();
            Console.Write("\nGracias por mirar estos bellos y hermosos arbolitos\nPreciona cualquier tecla para salir de mi bello programita");
            Console.ReadKey();
        }
    }
}
