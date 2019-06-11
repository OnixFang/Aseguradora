using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aseguradora.Data.Models;

namespace Aseguradora.Data
{
    public class InMemoryUsuarios : IUsuarioData
    {
        private readonly List<Usuario> usuarios;

        public InMemoryUsuarios()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario
                {
                    Id = 1,
                    Username = "agente",
                    Password = "agente",
                    Persona = null,
                    Rol = RolDeUsuario.Agente
                },
                new Usuario
                {
                    Id = 2,
                    Username = "supervisor",
                    Password = "supervisor",
                    Persona = null,
                    Rol = RolDeUsuario.Supervisor
                },
                new Usuario
                {
                    Id = 3,
                    Username = "gerente",
                    Password = "gerente",
                    Persona = null,
                    Rol = RolDeUsuario.Gerente
                }
            };
        }

        public Usuario AddUsuario(Usuario newUsuario)
        {
            int maxId = usuarios.Max(u => u.Id);
            newUsuario.Id = maxId;
            usuarios.Add(newUsuario);
            return newUsuario;
        }

        public Usuario GetUsuario(Credenciales credenciales)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Username == credenciales.Username && u.Password == credenciales.Password);
            return usuario;
        }

        public Usuario UpdateUsuario(Usuario updatedUsuario)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == updatedUsuario.Id);
            if (usuario != null)
            {
                usuario.Username = updatedUsuario.Username;
                usuario.Password = updatedUsuario.Password;
                usuario.Persona = updatedUsuario.Persona;
                usuario.Rol = updatedUsuario.Rol;
            }
            return usuario;
        }

        public Usuario DeleteUsuario(Usuario deteltedUsuario)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == deteltedUsuario.Id);
            if (usuario != null)
            {
                usuarios.Remove(deteltedUsuario);
            }
            return usuario;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
