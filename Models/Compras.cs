using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Compras
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdProducto { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
