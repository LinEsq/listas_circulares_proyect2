using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_doblementeenlazadas_circulares
{
    internal class ListaSimpleEnlazadaCanales
    {
        private NodoCanal Cabeza { get; set; } // atributos
        private NodoCanal actual;

        public ListaSimpleEnlazadaCanales()
        {
            Cabeza = null;
            actual = null;
        }

        public void AgregarCanal(string nombre, string url)
        {
            NodoCanal nuevo = new NodoCanal(nombre, url);

            if (Cabeza == null) //lista vacia
            {
                Cabeza = nuevo;
                Cabeza.Siguiente = Cabeza;
                Cabeza.Anterior = Cabeza;
                actual = Cabeza;
            }
            else
            {
                NodoCanal ultimo = Cabeza.Anterior; //funcion - lista que no esta vacia

                // Enlazar por el final
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;

                // Enlazar circular al inicio
                nuevo.Siguiente = Cabeza;
                Cabeza.Anterior = nuevo;
            }
        }

        public NodoCanal ObtenerSiguienteCanal() //funcion de pasar de canales
        {
            actual = actual.Siguiente;
            return actual;
        }

        public NodoCanal ObtenerAnteriorCanal()
        {
            actual = actual.Anterior;
            return actual;
        }

        public void Reiniciar()
        {
            actual = Cabeza;
        }

    }
}
