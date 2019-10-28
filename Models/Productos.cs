using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Productos
    {
        public Productos()
        {
            Compras = new HashSet<Compras>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Compras> Compras { get; set; }
    }
}
