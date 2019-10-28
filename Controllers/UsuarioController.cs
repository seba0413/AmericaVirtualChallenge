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
        // 
        // POST: /Usuario/Registro/
        [HttpPost]
        public UsuarioResponse Registro([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Registro(usuario);
        }

        // 
        // POST: /Usuario/Login/
        [HttpPost]
        public UsuarioResponse Login([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Login(usuario);
        }

        // 
        // POST: /Usuario/Logout/
        [HttpPost]
        public UsuarioResponse Logout([FromBody] Usuarios usuario)
        {
            return new Services.UsuarioService().Logout(usuario);
        }
    }
}