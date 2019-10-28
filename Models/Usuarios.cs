using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Compras = new HashSet<Compras>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool? Logueado { get; set; }

        public virtual ICollection<Compras> Compras { get; set; }
    }
}
