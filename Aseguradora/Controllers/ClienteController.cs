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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteData clienteData;

        public ClienteController(IClienteData clienteData)
        {
            this.clienteData = clienteData;
        }

        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return clienteData.GetClientes();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
