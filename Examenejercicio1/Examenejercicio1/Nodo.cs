using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenejercicio1
{
    class Nodo
    {
        private string dato;                      //Parametros del programita
        private Nodo hijo;
        private Nodo hermano;

        public string Dato                        //Los datos que se ingresaran
        {
            get => dato;
            set => dato = value;
        }
        public Nodo Hijo                          //Los nodos hijod
        {
            get => hijo;
            set => hijo = value;
        }
        public Nodo Hermano                       //Los nodos hermnanos
        {
            get => hermano;
            set => hermano = value;
        }
        public Nodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
