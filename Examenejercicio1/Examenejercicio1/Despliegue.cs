using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenejercicio1
{
    class Despliegue
    {
        Proceso Arbol = new Proceso();

        public void ArbolitoA()
        {
            Nodo raiz = Arbol.insertar("", null);
             Nodo raizB = Arbol.insertar("b", raiz);
              Nodo raizE = Arbol.insertar("e", raizB);
               Arbol.insertar("k", raizE);
               Arbol.insertar("l", raizE);
               Arbol.insertar("m", raizE);
              Arbol.insertar("f", raizB);
              Nodo raizG = Arbol.insertar("g", raizB);
               Nodo raizN = Arbol.insertar("n", raizG);
                Arbol.insertar("r", raizN);
                Arbol.insertar("s", raizN);
              Arbol.insertar("c", raiz);
              Nodo raizD = Arbol.insertar("d", raiz);
               Nodo raizH = Arbol.insertar("h", raizD);
                Arbol.insertar("o", raizH);
               Arbol.insertar("i", raizD);
               Nodo raizJ = Arbol.insertar("j", raizD);
            Arbol.insertar("p", raizJ);
            Arbol.insertar("q", raizJ);

            Console.WriteLine("Preorden");
            Arbol.TransPreo(raiz);
            Console.WriteLine("Postorden");
            Arbol.TransPost(raiz);
            Console.ReadKey();
        }
        public void ArbolitoB()
        {
            Nodo raiz = Arbol.insertar("a", null);
            Nodo raizB = Arbol.insertar("b", raiz);
            Arbol.insertar("c", raizB);
            Arbol.insertar("d", raizB);
            Nodo raizE = Arbol.insertar("e", raiz);
            Nodo raizF = Arbol.insertar("f", raizE);
            Arbol.insertar("g", raizF);
            Arbol.insertar("h", raizF);

            Console.WriteLine("Preorden");
            Arbol.TransPreo(raiz);
            Console.WriteLine("Postden");
            Arbol.TransPost(raiz);
            Console.ReadKey();
        }
    }
}