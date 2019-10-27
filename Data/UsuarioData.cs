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
            return new UsuarioResponse();
        }

        public UsuarioResponse Login(Usuarios usuario)
        {
            return new UsuarioResponse();
        }
    }
}
