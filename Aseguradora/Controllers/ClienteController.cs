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
        public Cliente Get(int id)
        {
            return clienteData.GetCliente(id);
        }

        // POST: api/Cliente
        [HttpPost]
        public Cliente Post([FromBody] Cliente newCliente)
        {
            return clienteData.AddCliente(newCliente);
        }

        // POST: api/Cliente/Update
        [HttpPost("Update")]
        public Cliente Update([FromBody] Cliente updatedCliente)
        {
            return clienteData.UpdateCliente(updatedCliente);
        }

        // DELETE: api/Cliente/Delete
        [HttpPost("Delete")]
        public Cliente Delete(Cliente deletedCliente)
        {
            return clienteData.DeleteCliente(deletedCliente);
        }
    }
}
