using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericaVirtualChallenge.Controllers.ResponseModels;
using AmericaVirtualChallenge.Models;

namespace AmericaVirtualChallenge.Services
{
    public class UsuarioService
    {
        public UsuarioResponse Registro(Usuarios usuario)
        {
            return new Data.UsuarioData().Registro(usuario);
        }

        public UsuarioResponse Login (Usuarios usuario)
        {
            return new Data.UsuarioData().Login(usuario);
        }
    }
}
