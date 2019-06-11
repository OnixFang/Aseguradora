using System;
using System.Collections.Generic;
using System.Linq;
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

        public Cliente AddCliente(Cliente newCliente)
        {
            clientes.Add(newCliente);
            return newCliente;
        }

        public Cliente DeleteCliente(Cliente deletedCliente)
        {
            clientes.Remove(deletedCliente);
            return deletedCliente;
        }

        public Cliente GetCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            return cliente;
        }

        public List<Cliente> GetClientes()
        {
            return clientes;
        }

        public Cliente UpdateCliente(Cliente updatedCliente)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == updatedCliente.Id);
            if (cliente != null)
            {
                cliente.Nombre = updatedCliente.Nombre;
                cliente.Apellido = updatedCliente.Apellido;
                cliente.Cedula = updatedCliente.Cedula;
                cliente.Telefono = updatedCliente.Telefono;
                cliente.Direccion = updatedCliente.Direccion;
                cliente.Ciudad = updatedCliente.Ciudad;
                cliente.Polizas = updatedCliente.Polizas;
            }
            return cliente;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
