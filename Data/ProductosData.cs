﻿using System;
using System.Collections.Generic;
using System.Linq;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;


namespace AmericaVirtualChallenge.Data
{
    public class ProductosData
    {
        public ProductoResponse GetProducto(int id)
        {
            ProductoResponse pRes = new ProductoResponse();

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    var producto = context.Productos.Where(x => x.Id == id).FirstOrDefault();

                    if (producto != null)
                        Mapper(pRes, producto);

                    else
                        pRes.Mensaje = "No se ha encontrado ningun producto con el identificador " + id;
                }            
            }
            catch (Exception ex)
            {
                pRes.Mensaje = ex.Message;
            }           

            return pRes;
        }

        public List<ProductoResponse> GetProductos()
        {
            List < ProductoResponse > listadoProductos = new List<ProductoResponse>();
            ProductoResponse pRes;

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    var productos = context.Productos.ToList();

                    if(productos != null)
                    {
                        foreach(var producto in productos)
                        {
                            pRes = new ProductoResponse();
                            Mapper(pRes, producto);
                            listadoProductos.Add(pRes);
                        }                       
                    }
                    else
                    {
                        pRes = new ProductoResponse();
                        pRes.Mensaje = "Sin productos";
                        listadoProductos.Add(pRes);
                    }
                        
                }
            }
            catch (Exception ex)
            {
                pRes = new ProductoResponse();
                pRes.Mensaje = ex.Message;
                listadoProductos.Add(pRes);
            }

            return listadoProductos;
        }

        private void Mapper(ProductoResponse pRes, Productos producto)
        {
            pRes.Id = producto.Id;
            pRes.Descripcion = producto.Descripcion;
            pRes.Precio = producto.Precio;
            pRes.Imagen = producto.Imagen;
        }
    }
}
