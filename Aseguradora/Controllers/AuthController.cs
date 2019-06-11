using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aseguradora.Data;
using Aseguradora.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioData usuarioData;

        public AuthController(IUsuarioData usuarioData)
        {
            this.usuarioData = usuarioData;
        }

        // GET: api/Auth
        [HttpPost("Login")]
        public Usuario Login([FromBody] Credenciales credenciales)
        {
            return usuarioData.GetUsuario(credenciales);
        }

        // POST: api/Auth/Add
        [HttpPost("Add")]
        public Usuario Post([FromBody] Usuario newUsuario)
        {
            return usuarioData.AddUsuario(newUsuario);
        }

        // PATCH: api/Auth/
        [HttpPatch]
        public Usuario Patch([FromBody] Usuario updatedUsuario)
        {
            return usuarioData.UpdateUsuario(updatedUsuario);
        }

        // DELETE: api/Auth/Delete
        [HttpPost("Delete")]
        public Usuario Delete([FromBody] Usuario deletedUsuario)
        {
            return usuarioData.DeleteUsuario(deletedUsuario);
        }
    }
}
