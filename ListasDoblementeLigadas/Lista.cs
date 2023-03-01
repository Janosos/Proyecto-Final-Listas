using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo Inicio;
        Nodo Fin;

        public bool Vacia()
        {
            if(Inicio == null &&  Fin == null)
            {
                return true;
            }
            // Para que el else
            return false;
        }

        public void Limpiar()
        {
            Inicio = null; 
            Fin = null;
        }

        public string RecorrerLista()
        {
            string valores = "";

            Nodo actual = Inicio;

            while (actual != null)
            {
                // Agrega el contenido a la cadena
                valores += actual.Contenido + "\n";
                actual = actual.Despues;
            }
            return valores;
        }

        public void AgregarAlFinal(string contenido)
        {
            Nodo nuevo = new Nodo(contenido);
            // Revisar si ha nodos 
            if(Vacia())
            {
                // Como solo existe uni no hay pierde
                Inicio = nuevo;
                Fin = nuevo;
                Inicio.Despues = Fin;
                Fin.Antes = Inicio;
            }
            else
            {
                // Agregamos las cosas a la mitad
                nuevo.Antes = Fin;
                Fin.Despues = nuevo;
                Fin = nuevo;
            }
        }

        public void AgregarAlInicio(string contenido)
        {
            // Agregado porque sale en el ejemplo

            Nodo nuevo = new Nodo(contenido);

            if(Vacia())
            {
                // Lo mismo que en la de agregar al final si no hay nada
                Inicio = nuevo;
                Fin = nuevo;
                Inicio.Despues = Fin;
                Fin.Antes = Inicio;
            }
            else
            {
                // Ahora solo mover la referencias
                nuevo.Despues = Inicio;
                Inicio.Antes = nuevo;
                Inicio = nuevo;
            }
        }

        public Nodo Buscar(string contenido)
        {
            // Si esta vacia no hay algo para buscar
            if (Vacia())
                return null;

            Nodo actual = Inicio;
            while (actual != null)
            {
                if (actual.Contenido == contenido)
                {
                    return actual;
                }
            }
            // Si no encontro lo que queriamos en la busqueda
            return null;
        }

        public void Borrar(string contenido)
        {
            if (!Vacia())
            {
                Nodo actual = Inicio;

                while (actual != null && actual.Contenido != contenido)
                {
                    // Solo busca la coincidencia
                    actual = actual.Despues;
                }

                // Responde si no encontro el nodo
                if (actual == null)
                {
                    Console.WriteLine("No se ha encontrado el nodo deseado");
                    return;
                }

                // Revisa si es el primero
                if (actual.Antes == null)
                {
                    Inicio = Inicio.Despues;
                }
                else
                {
                    actual.Antes.Despues = actual.Despues;
                }

                // Revisa si es el ultimo
                if (actual.Despues == null)
                {
                    Fin = Fin.Antes;
                }
                else
                {
                    actual.Despues.Antes = actual.Antes;
                }
            }
            else
            {
                Console.WriteLine("La lista no tiene nada");
            }
        }

    }
}
