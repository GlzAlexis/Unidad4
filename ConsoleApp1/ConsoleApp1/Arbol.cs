using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class ArbolBinarioOrdenado
        {
            class Nodo //Clase donde se crea el Nodo
            {
                public int info; //El valor del nodo
                public Nodo izq, der; //Los nodos que tiene a la izquierda o derecha
            }
            private Nodo raiz; //Raiz
            private int cant; //Cantidad de nodos
            private int altura; //Altura del árbol

            public ArbolBinarioOrdenado()
            {
                raiz = null; //Cuando se crea el objeto, no tiene ninguna raíz.
            }

            public void Insertar(int info) //Para insertar un nodo y de parametro llevav el valor del nodo.
            {
                if (!Existe(info)) //No puede haber dos nodos iguales.
                {
                    Nodo nuevo;
                    nuevo = new Nodo(); //Crea un nuevo nodo 
                    nuevo.info = info; //Asigna el valor del nodo.
                    nuevo.izq = null;
                    nuevo.der = null;
                    if (raiz == null)
                        raiz = nuevo; //Si no existe la raíz aún, el primer elemento es la raíz.
                    else //Si no, los acomoda dependiendo el valor. Derecha mayor, izquierda menor.
                    {
                        Nodo anterior = null, reco;
                        reco = raiz;
                        while (reco != null)
                        {
                            anterior = reco;
                            if (info < reco.info)
                                reco = reco.izq;
                            else
                                reco = reco.der;
                        }
                        if (info < anterior.info)
                            anterior.izq = nuevo;
                        else
                            anterior.der = nuevo;
                    }
                }
            }

            public bool Existe(int info)
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (info == reco.info)
                        return true;
                    else
                        if (info > reco.info)
                        reco = reco.der;
                    else
                        reco = reco.izq;
                }
                return false;
            }

            private void ImprimirEntre(Nodo reco) //Método recursivo para imprimir entre-orden.
            {
                if (reco != null)
                {
                    ImprimirEntre(reco.izq);
                    Console.Write(reco.info + " ");
                    ImprimirEntre(reco.der);
                }
            }

            public void ImprimirEntre() //Imprimir entre-orden.
            {
                ImprimirEntre(raiz);
                Console.WriteLine();
            }


            private void Cantidad(Nodo reco) //Cantidad de nodos.
            {
                if (reco != null)
                {
                    cant++;
                    Cantidad(reco.izq);
                    Cantidad(reco.der);
                }
            }

            public int Cantidad() //Cantidad de nodos.
            {
                cant = 0;
                Cantidad(raiz);
                return cant;
            }

            private void CantidadNodosHoja(Nodo reco) //Cuantas hojas hay en el árbol. (método recursivo)
            {
                if (reco != null)
                {
                    if (reco.izq == null && reco.der == null)
                        cant++;
                    CantidadNodosHoja(reco.izq);
                    CantidadNodosHoja(reco.der);
                }
            }

            public int CantidadNodosHoja() //Cuantas hojas hay en el árbol. (método recursivo)
            {
                cant = 0;
                CantidadNodosHoja(raiz);
                return cant;
            }

            private void ImprimirEntreConNivel(Nodo reco, int nivel) //Método para imprimir el entre-orden y el nivel de dicha hoja. (recursivo)
            {
                if (reco != null)
                {
                    ImprimirEntreConNivel(reco.izq, nivel + 1);
                    Console.Write(reco.info + " (" + nivel + ") - ");
                    ImprimirEntreConNivel(reco.der, nivel + 1);
                }
            }

            public void ImprimirEntreConNivel() //Método para imprimir el entre-orden y el nivel de dicha hoja. (recursivo)
            {
                ImprimirEntreConNivel(raiz, 1);
                Console.WriteLine();
            }

            private void RetornarAltura(Nodo reco, int nivel) //Método recursivo para determinar la altura del árbol.
            {
                if (reco != null)
                {
                    RetornarAltura(reco.izq, nivel + 1);
                    if (nivel > altura)
                        altura = nivel;
                    RetornarAltura(reco.der, nivel + 1);
                }
            }

            public int RetornarAltura() //Método recursivo para determinar la altura del árbol.
            {
                altura = 0;
                RetornarAltura(raiz, 1);
                return altura;
            }

            public void MayorValorl() //Método para determinar cuál es el elemento con mayor valor en el árbol.
            {
                if (raiz != null)
                {
                    Nodo reco = raiz;
                    while (reco.der != null)
                        reco = reco.der;
                    Console.WriteLine("Mayor valor del árbol:" + reco.info);
                }
            }
        }
    }

}
