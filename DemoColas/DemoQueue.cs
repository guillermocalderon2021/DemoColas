using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoColas
{
    class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<String> miCola = new Queue<string>();
  
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------ DEMO COLAS -------------:");
                Console.WriteLine("1) Agregar elemento a la cola");
                Console.WriteLine("2) Mostrar cola");
                Console.WriteLine("3) Quitar elemento de la cola");
                Console.WriteLine("4) Mostrar primer elemento de la cola");
                Console.WriteLine("0) Salir");
                Console.Write("\r\nSelecciona una opcion: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingresa un elemento:");
                        string nombre = Console.ReadLine();
                        miCola.Enqueue(nombre);
                        break;
                    case "2":
                        if (miCola.Count == 0)
                        {
                            Console.WriteLine("Cola vacia");
                        }
                        else
                        {
                            foreach (string n in miCola)
                            {
                                Console.WriteLine(n);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        
                        if (miCola.Count == 0)
                        {
                            Console.WriteLine("No hay elementos en la cola");
                        }
                        else
                        {
                            string eliminado = miCola.Dequeue();
                            Console.WriteLine("Nodo eliminado: " + eliminado);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Elemento al frente de la cola: " + miCola.Peek());
                        Console.ReadKey();
                        break;
                    case "0":
                        
                        return;
                    default:
                        break;
                }

            }
        }
    }
}
