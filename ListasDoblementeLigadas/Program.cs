using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarAlFinal("Uno");
            lista.AgregarAlFinal("Dos");
            lista.AgregarAlInicio("Tres");
            lista.AgregarAlFinal("Cuatro");
            Console.WriteLine(lista.RecorrerLista());

            // Para busqueda
            Console.WriteLine("Pruebas de busqueda");
            Nodo nodoBusqueda = lista.Buscar("Tres");
            if (nodoBusqueda != null)
                Console.WriteLine(nodoBusqueda.Contenido);
            else
                Console.WriteLine("No encontrado");

            Console.WriteLine("Eliminando el Cuatro");
            lista.Borrar("Cuatro");
            Console.WriteLine(lista.RecorrerLista());

            Console.ReadLine();
        }
    }
}
