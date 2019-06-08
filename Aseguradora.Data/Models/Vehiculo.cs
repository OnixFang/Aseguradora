using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public MarcaDeCarro Marca { get; set; }
        public int Anio { get; set; }
    }
}
