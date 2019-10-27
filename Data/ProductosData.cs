using System.Collections.Generic;
using AmericaVirtualChallenge.Controllers.ResponseModels;

namespace AmericaVirtualChallenge.Data
{
    public class ProductosData
    {
        public ProductoResponse GetProducto(int id)
        {
            ProductoResponse pRes = new ProductoResponse();

            return pRes;
        }

        public List<ProductoResponse> GetProductos()
        {
            List < ProductoResponse > listadoProductos = new List<ProductoResponse>();
            return listadoProductos;
        }
    }
}
