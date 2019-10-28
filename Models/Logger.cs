using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Logger
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Accion { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
