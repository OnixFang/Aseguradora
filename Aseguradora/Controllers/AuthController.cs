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

        //// GET: api/Auth
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Auth/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/Auth
        [HttpPost("Login")]
        public Usuario Login([FromBody] Credenciales credenciales)
        {
            return usuarioData.GetUsuario(credenciales);
        }

        // POST: api/Auth
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

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public Usuario Delete([FromBody] Usuario deletedUsuario)
        {
            return usuarioData.DeleteUsuario(deletedUsuario);
        }
    }
}
