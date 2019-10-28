using AmericaVirtualChallenge.Data;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using System.Collections.Generic;
using AmericaVirtualChallenge.Models;
using System;

namespace AmericaVirtualChallenge.Services
{
    public class ProductosService
    {
        public ProductoResponse GetProducto(int id)
        {
            return new ProductosData().GetProducto(id);
        }

        public List<ProductoResponse> GetProductos()
        {
            return new ProductosData().GetProductos();
        }

        public ProductoResponse AltaProducto(Productos producto)
        {
            return new ProductosData().AltaProducto(producto);
        }
    }
}
