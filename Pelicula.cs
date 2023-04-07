using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Pelicula
    {
        public int id { get; set;}

        public string Nombre { get; set;}

        public string Sinopsis { get; set;}
        public string poster { get; set;}
        public List<Funcion> MisFunciones { get; set;}
        public int Duracion { get; set;}
     public Pelicula() { }
    }
}
