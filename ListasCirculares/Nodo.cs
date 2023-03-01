using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Nodo
    {
        public Nodo Siguiente { get; set; }
        public string Contenido { get; set; }

        public Nodo(string valor)
        {
            Contenido = valor;
            Siguiente = null;
        }
    }
}
