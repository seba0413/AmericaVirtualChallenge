using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AmericaVirtualChallenge.Services;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using System.Text.Encodings.Web;

namespace AmericaVirtualChallenge.Controllers
{
    public class ProductosController : Controller
    {
        /// <summary>
        /// Obtiene un producto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Productos/GetProducto/{id}")]
        public ProductoResponse GetProducto(int id)
        {
            return new ProductosService().GetProducto(id);
        }

        /// <summary>
        /// Obtiene todos los productos de forma paginada
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Productos/GetProductos/")]

        public List<ProductoResponse> GetProductos([FromQuery]int? page)
        {
            const int pageSize = 2;

            var productos = new ProductosService().GetProductos();

            var productosPaginados =   productos.Skip((page ?? 0) * pageSize)
                                                .Take(pageSize)
                                                .ToList();

            return productosPaginados;
        }
    }
}