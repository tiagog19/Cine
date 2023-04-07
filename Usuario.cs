using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Usuario
    {
        public int id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int IntentosFallidos { get; set; }
        public bool Bloqueado { get; set; }
        public List<Funcion> MisFunciones { get; set; }
        public double Credito { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsAdmin { get; set; }

        public Usuario() { }
    }
}
