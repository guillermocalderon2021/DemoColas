using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoColas
{
    class Nodo
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo(int valor)
        {
            this.dato = valor;
            this.siguiente = null;
        }

        public Nodo()
        {

        }

    }
}
