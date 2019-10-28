using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;

namespace AmericaVirtualChallenge.Data
{
    public class UsuarioData
    {
        public UsuarioResponse Registro(Usuarios usuario)
        {
            UsuarioResponse uRes = new UsuarioResponse();

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    var user = context.Usuarios.Where(u => u.Usuario == usuario.Usuario)
                         .Select(x => new Usuarios
                         {
                             Usuario = x.Usuario

                         }).FirstOrDefault();
                
                    if (user != null)
                    {
                        uRes.Mensaje = "El nombre de usuario ya se encuentra en uso";
                    }
                    else
                    {
                        context.Usuarios.Add(usuario);
                        context.SaveChanges();
                        Mapper(uRes, usuario, false, "Usuario registrado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                uRes.Mensaje = ex.Message;
            }

            return uRes;
        }

        public UsuarioResponse Login(Usuarios usuario)
        {
            UsuarioResponse uRes = new UsuarioResponse();

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    var user = context.Usuarios.Where(u => u.Usuario == usuario.Usuario && u.Clave == usuario.Clave).FirstOrDefault();

                    if (user == null)
                    {
                        uRes.Mensaje = "Nombre de usuario y / o contraseña incorrectos";
                    }
                    else
                    {
                        user.Logueado = true;
                        context.SaveChanges();
                        Mapper(uRes, user);
                        LoggerData.InsertLogger(user.Id, "Login");
                    }
                }
            }
            catch (Exception ex)
            {
                uRes.Mensaje = ex.Message;
            }

            return uRes;
        }

        public UsuarioResponse Logout(Usuarios usuario)
        {
            UsuarioResponse uRes = new UsuarioResponse();

            try
            {
                using (ServiciosContext context = new ServiciosContext())
                {
                    var user = context.Usuarios.Where(u => u.Usuario == usuario.Usuario).FirstOrDefault();

                    user.Logueado = false;
                    context.SaveChanges();
                    Mapper(uRes, user);
                    LoggerData.InsertLogger(user.Id, "Logout");
                }
            }
            catch (Exception ex)
            {
                uRes.Mensaje = ex.Message;
            }

            return uRes;
        }

        private void Mapper(UsuarioResponse uRes, Usuarios usuario, bool logueado, string mensaje)
        {
            uRes.Id = usuario.Id;
            uRes.Nombre = usuario.Nombre;
            uRes.Apellido = usuario.Apellido;
            uRes.Usuario = usuario.Usuario;
            uRes.Logueado = logueado;
            uRes.Mensaje = mensaje;
        }
        private void Mapper(UsuarioResponse uRes, Usuarios usuario)
        {
            uRes.Id = usuario.Id;
            uRes.Nombre = usuario.Nombre;
            uRes.Apellido = usuario.Apellido;
            uRes.Usuario = usuario.Usuario;
            uRes.Logueado = usuario.Logueado;
        }
    }
}
