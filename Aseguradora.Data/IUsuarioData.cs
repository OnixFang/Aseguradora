using Aseguradora.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data
{
    public interface IUsuarioData
    {
        Usuario AddUsuario(Usuario newUsuario);
        Usuario GetUsuario(Credenciales credenciales);
        Usuario UpdateUsuario(Usuario updatedUsuario);
        Usuario DeleteUsuario(Usuario deletedUsuario);
        int Commit();
    }
}
