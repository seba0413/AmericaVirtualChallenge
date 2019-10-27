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
        // 
        // GET: /Productos/GetProducto/{id}
        public ProductoResponse GetProducto(int id)
        {
            return new ProductosService().GetProducto(id);
        }

        // 
        // GET: /Productos/GetProductos?page={page}
        public List<ProductoResponse> GetProductos(int? page)
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