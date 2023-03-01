using System;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string Contenido { get; set; }

        public Nodo Antes { get; set; }

        public Nodo Despues { get; set; }

        public Nodo(string contenido)
        { 
            Contenido = contenido;

            // Para ser configurados despues en la ejecucion
            Antes = null;
            
            Despues = null;
        }
    }
}
