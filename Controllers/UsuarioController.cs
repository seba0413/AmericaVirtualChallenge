using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;

namespace AmericaVirtualChallenge.Controllers
{
    public class UsuarioController : Controller
    {
        /// <summary>
        /// Registro de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Usuario/Registro/")]
        public UsuarioResponse Registro([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Registro(usuario);
        }

        /// <summary>
        /// Login de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Usuario/Login/")]
        public UsuarioResponse Login([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Login(usuario);
        }

        /// <summary>
        /// Logout de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Usuario/Logout/")]
        public UsuarioResponse Logout([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Logout(usuario);
        }
    }
}