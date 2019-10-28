using Microsoft.AspNetCore.Mvc;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;
using AmericaVirtualChallenge.Services;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Controllers
{
    public class ComprasController : Controller
    {
        // 
        // POST: /Compras/AltaCompra/
        [HttpPost]
        public CompraResponse AltaCompra([FromBody] Compras compra)
        {
            return new ComprasService().AltaCompra(compra);
        }

        // 
        // GET: /Compras/GetCompras/{id}
        public List<CompraResponse> GetCompras (int id = 0)
        {
            return new ComprasService().GetCompras(id);
        }
    }
}