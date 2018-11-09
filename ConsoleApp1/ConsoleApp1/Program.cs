using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado(); //Creamos el objeto abo de la clase.
            abo.Insertar(15); //Inserta los elementos
            abo.Insertar(7);
            abo.Insertar(18);
            abo.Insertar(5);
            abo.Insertar(12);
            abo.Insertar(25);
            abo.Insertar(10);
            abo.Insertar(14);
            abo.Insertar(23);
            Console.WriteLine("Impresion entreorden: "); //Imprime el entreorden.
            abo.ImprimirEntre();
            Console.WriteLine("Cantidad de nodos del árbol:" + abo.Cantidad()); //Imprime la cantidad de nodos.
            Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja()); //Imprime la cantidad de nodos hojas.
            Console.WriteLine("\nImpresion el entre orden junto al nivel del nodo."); //Imprime el entre orden y el nivel de nodos.
            abo.ImprimirEntreConNivel();
            Console.Write("Altura del arbol:"); //Imprime la altura del árbol.
            Console.WriteLine(abo.RetornarAltura());
            abo.MayorValorl(); //Imprime el valor mayor.
            Console.ReadKey();

        }
    }
}
