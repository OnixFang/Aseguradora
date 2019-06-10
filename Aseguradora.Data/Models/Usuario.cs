using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public IPersona Persona { get; set; }
    }
}
