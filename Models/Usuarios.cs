using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
