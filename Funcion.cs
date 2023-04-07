using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Funcion
    {
        public int id { get; set; }
       
        public Sala MiSala { get; set; }

        public Pelicula MiPelicula { get; set; }

        public List<Usuario> Clientes { get; set; }

        public DateTime Fecha { get; set; }
        public int CantClientes { get; set; }
        public double Costo { get; set; }

        public Funcion() { }

    }
}
