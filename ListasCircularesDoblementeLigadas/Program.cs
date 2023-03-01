using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cero");

            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Eliminando Tres");
            lista.EliminarNodo("Tres");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Buscando Dos");
            Nodo busqueda = lista.Buscar("Dos");
            if(busqueda != null)
            {
                Console.WriteLine(busqueda.Contenido);
            }
            else
            {
                Console.WriteLine("No se encontro el nodo");
            }
            Console.ReadKey();
        }
    }
}
