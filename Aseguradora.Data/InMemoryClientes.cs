using System;
using System.Collections.Generic;
using System.Text;
using Aseguradora.Data.Models;

namespace Aseguradora.Data
{
    public class InMemoryClientes : IClienteData
    {
        readonly List<Cliente> clientes;

        public InMemoryClientes()
        {
            clientes = new List<Cliente>()
            {
                new Cliente{
                    Id = 1,
                    Nombre = "Ulises",
                    Apellido = "Taveras",
                    Cedula = "402-0000000-5",
                    Ciudad = "Santiago",
                    Direccion = "Pastor",
                    Telefono = "809-555-5555"
                },
                new Cliente{
                    Id = 2,
                    Nombre = "Janibel",
                    Apellido = "Espinal",
                    Cedula = "402-0000000-4",
                    Ciudad = "Santiago",
                    Direccion = "La Rosaleda",
                    Telefono = "809-777-7777"
                }
            };
        }

        public List<Cliente> GetClientes()
        {
            return clientes;
        }
    }
}
