using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public interface IEmpleado
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        RolDeEmpleado Rol { get; set; }
    }
}
