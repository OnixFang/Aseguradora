using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public class Agente : IEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public RolDeEmpleado Rol { get; set; }
        public List<Poliza> Polizas { get; set; }
    }
}
