using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;
using AmericaVirtualChallenge.Data;

namespace AmericaVirtualChallenge.Services
{
    public class ComprasService
    {
        public CompraResponse AltaCompra(Compras compra)
        {
            return new ComprasData().AltaCompra(compra);
        }

        public List<CompraResponse> GetCompras(int idUsuario)
        {
            return new ComprasData().GetCompras(idUsuario);
        }
    }
}
