using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;

namespace AmericaVirtualChallenge.Data
{
    public class ComprasData
    {
        public CompraResponse AltaCompra(Compras compra)
        {
            CompraResponse cRes = new CompraResponse();

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    context.Compras.Add(compra);
                    context.SaveChanges();
                    cRes.Mensaje = "La compra se registro correctamente";
                    LoggerData.InsertLogger(compra.IdUsuario, "Compra");
                }
            }
            catch (Exception ex)
            {
                cRes.Mensaje = ex.Message;
            }

            return cRes;
        }

        public List<CompraResponse> GetCompras(int idUsuario)
        {
            List<CompraResponse> listadoCompras = new List<CompraResponse>();
            CompraResponse cRes;

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    if(idUsuario == 0)
                    {
                        var compras = (from c in context.Compras
                                       join u in context.Usuarios
                                       on c.IdUsuario equals u.Id
                                       join p in context.Productos
                                       on c.IdProducto equals p.Id
                                       select new CompraResponse
                                       {
                                           IdCompra = c.Id,
                                           Producto = p.Descripcion,
                                           Usuario = u.Usuario,
                                           Precio = (double)p.Precio
                                       }).ToList();  
                        
                        foreach(var compra in compras)
                        {
                            listadoCompras.Add(compra);
                        }
                    } 
                    else
                    {
                        var compras = (from c in context.Compras
                                       join u in context.Usuarios
                                       on c.IdUsuario equals u.Id
                                       join p in context.Productos
                                       on c.IdProducto equals p.Id
                                       where c.IdUsuario == idUsuario
                                       select new CompraResponse
                                       {
                                           IdCompra = c.Id,
                                           Producto = p.Descripcion,
                                           Usuario = u.Usuario,
                                           Precio = (double)p.Precio
                                       }).ToList();

                        foreach (var compra in compras)
                        {
                            listadoCompras.Add(compra);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cRes = new CompraResponse();
                cRes.Mensaje = ex.Message;
                listadoCompras.Add(cRes);
            }

            return listadoCompras;
        }
    }
}
