using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            // Para la lista el el final es el anterior al inicio
            // Agregar al principio y al final es lo mismo, no?
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cero");

            Console.WriteLine(lista.RecorrerLista());

            lista.Eliminar("Dos");
            Console.WriteLine(lista.RecorrerLista());

            Nodo busqueda = lista.Buscar("Cero");
            if (busqueda != null)
                Console.WriteLine(busqueda.Contenido);
            else
                Console.WriteLine("No encontrado");

            Console.ReadKey();
        }
    }
}
