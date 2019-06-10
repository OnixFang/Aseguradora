using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public interface IPersona
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        RolDeUsuario Rol { get; set; }
    }
}
