using Microsoft.AspNetCore.Mvc;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;
using AmericaVirtualChallenge.Services;
using System.Collections.Generic;

namespace AmericaVirtualChallenge.Controllers
{
    public class ComprasController : Controller
    {
        /// <summary>
        /// Da de alta una nueva compra
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>     
        [HttpPost]
        [Route("Compras/AltaCompra/")]
        public CompraResponse AltaCompra([FromBody] Compras compra)
        {
            return new ComprasService().AltaCompra(compra);
        }

        /// <summary>
        /// Obtiene el listado de las compras totales o de un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>    
        [HttpGet]
        [Route("Compras/GetCompras/")]
        public List<CompraResponse> GetCompras (int id = 0)
        {
            return new ComprasService().GetCompras(id);
        }
    }
}