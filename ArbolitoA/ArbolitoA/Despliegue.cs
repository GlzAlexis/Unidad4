using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolitoA
{
    class Despliegue
    {
        Arbolito Arbol = new Arbolito();                    //Aqui se insertan los datos que son requeridos y donde tienen que estar para que
                                                            //La construnccion del arbol este bien definida
        public void ArbolitoA()
        {
            Nodo raiz = Arbol.insertar("E", null);
            Arbol.insertar("F", raiz);
            Nodo raiza = Arbol.insertar("A", raiz);
            Arbol.insertar("C", raiza);  
            Arbol.insertar("B", raiza);  
            Arbol.insertar("D", raiza);
            Arbol.TransPreo(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura(), 2);
            Console.WriteLine("La ruta mas larga es hacia C, B y D: \nE -> A -> C\nE -> A -> B\nE -> A -> D");
        }
        public void ArbolitoB()
        {
            Nodo raiz = Arbol.insertar("C", null);
            Nodo raiza = Arbol.insertar("A", raiz);
            Nodo raizb = Arbol.insertar("B", raiza);
            Arbol.insertar("E", raizb);
            Arbol.insertar("D", raiz);
            Arbol.insertar("F", raiz);
            Arbol.insertar("G", raiz);
            Arbol.TransPreo(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura() - 1, 3);
            Console.WriteLine("La ruta mas larga es hacia E: \nC -> A -> B -> E");
        }
        public void ArbolitoC()
        {
            Nodo raiz = Arbol.insertar("K", null);
            Arbol.insertar("A", raiz);
            Arbol.insertar("B", raiz);
            Arbol.insertar("C", raiz);
            Nodo raiza = Arbol.insertar("D", raiz);
            Nodo raizi = Arbol.insertar("I", raiza);
            Arbol.insertar("J", raizi);
            Nodo raize = Arbol.insertar("E", raiza);
            Arbol.insertar("F", raize);
            Nodo raizg = Arbol.insertar("G", raize);
            Arbol.insertar("H", raizg);
            Arbol.TransPreo(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura() + 2, 4);
            Console.WriteLine("La ruta mas larga es hacia H: \nK -> D -> E -> G -> H");
            Console.WriteLine("La ruta hacia C es: K -> C \nLa ruta hacia J es: K -> D -> I -> J");
        }
    }
}
