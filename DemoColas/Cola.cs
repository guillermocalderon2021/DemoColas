using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoColas
{
    class Cola
    {
        private Nodo primero;
        private Nodo ultimo;
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Cola()
        {
            primero = null;
            ultimo = null;
            cantidad = 0;
        }

        //Este método inserta un nodo al inicio de la cola
        public void Encolar(int valor)
        {
            // Creamos un nodo con el valor que se recibe como parametro
            Nodo nuevo = new Nodo(valor);
            if (primero == null) // Si no hay ningun nodo en la cola
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else // si ya hay algun elemento en la cola
            {
                //Le agregamos la referencia al ultimo nodo
                ultimo.Siguiente = nuevo;
                // El nuevo nodo se convierte en el ultimo
                ultimo = nuevo;
                // El ultimo elemento apunta a null
                ultimo.Siguiente = null;
            }
            cantidad++; //aumentamos el contador de nodos
        }

        // Método que recorre e imprime los elementos de la cola
        public void Imprimir()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }

        public Nodo VerFrente()
        {
            return primero;
        }

        public Nodo Desencolar()
        {
            if (primero == null) // Si la cola está vacia
            {
                return null;
            }
            else
            {
                Nodo auxiliar = new Nodo();
                auxiliar = primero; // Guardamos en "auxiliar" el nodo a eliminar
                primero = primero.Siguiente; // El "siguiente" del primer nodo se convierte en el "primero"
                auxiliar.Siguiente = null; // Rompemos la referencia
                cantidad--; // Disminuimos el contador de nodos
                return auxiliar;
            }
        }


    }
}
