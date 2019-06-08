using Aseguradora.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data
{
    public interface IClienteData
    {
        List<Cliente> GetClientes();
    }
}
