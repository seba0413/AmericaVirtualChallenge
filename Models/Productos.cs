using System;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Models
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }
}
