using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
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
            // Se podra llamar al constructor?
            Inicio = null;
        }

        public bool Vacia()
        {
            if (Inicio == null)
            {
                return true;
            }
            return false;
        }

        public string RecorrerLista()
        {
            string cadena = "";
            Nodo actual = Inicio;

            // Empieza a recorrer
            while (!ReferenceEquals(actual.Siguiente, Inicio) && actual != null)
            {
                cadena += actual.Contenido + "\n";
                actual = actual.Siguiente;
            }

            // No se, siempre falta el ultimo
            cadena += actual.Contenido + "\n";
            return cadena.ToString();
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            Nodo actual = Inicio;
            if (Inicio == null)
            {
                // Primer elemento
                Inicio = nuevo;
                Inicio.Siguiente = Inicio;
                return;
            }
            else if (ReferenceEquals(actual.Siguiente, Inicio))
            {
                // Segundo elemento
                Inicio.Siguiente = nuevo;
                nuevo.Siguiente = Inicio;
            }
            else
            {
                // Cualquier otro elemento
                while (!ReferenceEquals(actual.Siguiente, Inicio))
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = Inicio;

            }
            // Debe haber forma de juntar el segundo con el resto?
        }

        public Nodo Buscar(string contenido)
        {
            if (Vacia()) return null;

            Nodo actual = Inicio;

            // Si hay un solo elemento queda ver si es lo que esperamos
            if (actual.Siguiente == Inicio && actual.Contenido == contenido)
            {
                return actual;
            }
            // Si son mas buscamos
            actual = actual.Siguiente;
            while (!ReferenceEquals(actual, Inicio))
            {
                if (actual.Contenido == contenido)
                {
                    return actual;
                }
                // No olvidar avanzar al siguiente
                actual = actual.Siguiente;
            }

            // Por si no encontro nada igual
            return null;

        }

        public void Eliminar(string contenido)
        {
            // Revisar si esta vacia
            if (Vacia()) Console.WriteLine("Lista vacia"); ;

            Nodo actual = Inicio;

            // Cuando solo hay uno
            if(ReferenceEquals(actual.Siguiente, Inicio))
            {
                // Si solo hay uno eliminarlo es
                // igual a vaciarla
                Vaciar();
            }
            // Busca una coincidencia (cambiar por buscar?)
            while (!ReferenceEquals(actual.Siguiente, Inicio))
            {
                if (actual.Siguiente.Contenido == contenido)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    // Si es el primero hay que mover la referencia de inicio
                    if (ReferenceEquals(actual.Siguiente, Inicio))
                        Inicio = Inicio.Siguiente;
                    return;
                }
                actual = actual.Siguiente;
            }

            Console.WriteLine("Nodo no encontrado");
        }


    }
}
