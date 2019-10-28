using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Compras
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
    }
}
