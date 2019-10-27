using AmericaVirtualChallenge.Data;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using System.Collections.Generic;

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
    }
}
