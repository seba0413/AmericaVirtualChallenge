using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtualChallenge.Controllers.ResponseModels
{
    public class CompraResponse
    {
        public int IdCompra { get; set; }

        public string Producto { get; set; }

        public double Precio { get; set; }

        public string Usuario { get; set; }

        public string Mensaje { get; set; }
    }
}
