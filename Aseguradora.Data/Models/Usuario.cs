﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IPersona Persona { get; set; }
        public RolDeUsuario Rol { get; set; }
    }
}
