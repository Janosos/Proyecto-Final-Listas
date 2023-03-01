using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Lista
    {
        Nodo Inicio;

        public Lista()
        {
            Inicio = null;
        }

        public void Vaciar()
        {
            Inicio = null;
        }

        public bool Vacia()
        {
            // Muy largo, se puede hacer mas corto?
            if (Inicio == null)
            {
                return true;
            }
            return false;
        }

        public string RecorrerLista()
        {
            StringBuilder cadena = new StringBuilder();
            Nodo actual = Inicio;
            while (!ReferenceEquals(actual.Despues, Inicio) && actual != null)
            {
                cadena.Append(actual.Contenido + "\n");
                actual = actual.Despues;
            }
            // No se porque falta el ultimo
            cadena.Append(actual.Contenido + "\n");
            return cadena.ToString();
        }


        public Nodo Buscar(string valor)
        {
            if (Vacia()) return null;
            Nodo actual = Inicio;

            while (!ReferenceEquals(actual.Despues, Inicio))
            {
                if (actual.Contenido == valor)
                {
                    return actual;
                }
                actual = actual.Despues;
            }

            // Debe haber forma de juntar esto con la vacia
            return null;
        }

        public void EliminarNodo(string valor)
        {
            if (Vacia()) Console.WriteLine("La lista esta vacia");
            if (ReferenceEquals(Inicio, Inicio.Despues) && ReferenceEquals(Inicio, Inicio.Antes))
            {
                // Revisar si solo hay un nodo en la lista
                Vaciar();
            }
            Nodo actual = Inicio;
            while (!ReferenceEquals(actual.Despues, Inicio))
            {
                if (actual.Contenido == valor)
                {
                    actual.Antes.Despues = actual.Despues;
                    actual.Despues.Antes = actual.Antes;
                    if (ReferenceEquals(actual, Inicio))
                    {
                        // Si es el inicio movemos la referencia
                        // Otra vez
                        Inicio = Inicio.Despues;
                    }
                    return;
                }
                actual = actual.Despues;
            }
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Vacia())
            {
                // Primer elemento, todo apunta a este ahora
                Inicio = nuevo;
                Inicio.Despues = Inicio;
                Inicio.Antes = Inicio;
                return;
            }
            if (ReferenceEquals(Inicio, Inicio.Antes) && ReferenceEquals(Inicio, Inicio.Despues))
            {
                // Si hay un solo elemento
                Inicio.Despues = nuevo;
                Inicio.Antes = nuevo;
                nuevo.Despues = Inicio;
                nuevo.Antes = Inicio;
                return;
            }
            // Para el resto
            // Creo que hay forma de juntar lo anterior con este
            Nodo actual = Inicio.Despues;
            while (!ReferenceEquals(actual.Despues, Inicio))
            {
                actual = actual.Despues;
            }
            nuevo.Antes = actual;
            nuevo.Despues = Inicio;
            actual.Despues = nuevo;
            Inicio.Antes = nuevo;
        }
    }
}
