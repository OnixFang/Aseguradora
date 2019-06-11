using Aseguradora.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data
{
    public interface IClienteData
    {
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);
        Cliente AddCliente(Cliente newCliente);
        Cliente UpdateCliente(Cliente updatedCliente);
        Cliente DeleteCliente(Cliente deletedCliente);
        int Commit();
    }
}
