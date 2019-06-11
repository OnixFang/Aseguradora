using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public class Poliza
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Empleado Agente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
