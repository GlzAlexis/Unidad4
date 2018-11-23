using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenejercicio1
{
    class Proceso
    {
        private Nodo raiz;        //El nodo raiz
        private Nodo trabajo;     //Nos ayudara con algunas cosillas
        private int i = 0;        //Una variable cualquiera
        public int altura = 0;     //Calculo de la altura

        public Proceso() { raiz = new Nodo(); } //Se inicializa el nodo raiz
        public Nodo insertar(string Pdato, Nodo Pnodo)    //Este metodo es para insertar nuevos nodos
        {
            if (Pnodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = Pdato;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            if (Pnodo.Hijo == null)
            {
                Nodo temporal = new Nodo();
                temporal.Dato = Pdato;
                Pnodo.Hijo = temporal;
                return temporal;
            }
            else
            {
                trabajo = Pnodo.Hijo;
                while (trabajo.Hermano != null) { trabajo = trabajo.Hermano; }
                Nodo temporal = new Nodo();
                temporal.Dato = Pdato;
                trabajo.Hermano = temporal;
                return temporal;
            }
        }
        public void TransPreo(Nodo Pnodo)   //Este metodo es el que acomoda 
        {
            if (Pnodo == null) { return; }
            for (int j = 0; j < i; j++) { Console.Write("~"); }
            Console.WriteLine(Pnodo.Dato);
            if (Pnodo.Hijo != null)
            {
                i++;
                TransPreo(Pnodo.Hijo);
                i--;
            }
            if (Pnodo.Hermano != null) { TransPreo(Pnodo.Hermano); }
        }
        public void TransPost(Nodo Pnodo)   //Este metodo es el que acomoda 
        {
            if (Pnodo == null) { return; }
            for (int j = 0; j < i; j++) { Console.Write("~"); }
            
            if (Pnodo.Hijo != null)
            {
                i++;
                i--;
                TransPreo(Pnodo.Hijo);
            }
            Console.WriteLine(Pnodo.Dato);
            if (Pnodo.Hermano != null) { TransPreo(Pnodo.Hermano); }
        }
        private void Calculo(Nodo hoja, int e) //Este metodo calcula la altura del arbol
        {                                      //El cual solo logre con uno bien hecho
            if (hoja != null)
            {
                if (e <= altura)
                {
                    altura = e;
                    Calculo(hoja.Hijo, e);
                    altura++;
                }
            }
        }
        public int Altura() //Metofo para la altura
        {
            altura = 1;
            Calculo(raiz, altura);
            return altura;
        }
    }
}
