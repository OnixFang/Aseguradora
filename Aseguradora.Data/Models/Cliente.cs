using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public List<Poliza> Polizas { get; set; }
    }
}
