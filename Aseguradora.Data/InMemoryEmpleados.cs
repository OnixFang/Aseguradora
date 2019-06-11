using Aseguradora.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseguradora.Data
{
    public class InMemoryEmpleados
    {
        private readonly List<Empleado> empleados;

        public InMemoryEmpleados()
        {
            empleados = new List<Empleado>();
        }

        public Empleado AddEmpleado(IPersona newEmpleado)
        {
            int maxId = empleados.Max(e => e.Id);
            newEmpleado.Id = maxId;
            empleados.Add((Empleado)newEmpleado);
            return (Empleado)newEmpleado;
        }

        public List<Empleado> GetAll()
        {
            return empleados;
        }

        public Empleado UpdateEmpleado(Empleado updatedEmpleado)
        {
            var Empleado = empleados.FirstOrDefault(e => e.Id == updatedEmpleado.Id);
            if (Empleado != null)
            {
                Empleado.Nombre = updatedEmpleado.Nombre;
                Empleado.Apellido = updatedEmpleado.Apellido;
                Empleado.Polizas = updatedEmpleado.Polizas;
            }
            return Empleado;
        }

        public Empleado DeleteEmpleado(Empleado deteltedEmpleado)
        {
            var empleado = empleados.FirstOrDefault(e => e.Id == deteltedEmpleado.Id);
            if (empleado != null)
            {
                empleados.Remove(deteltedEmpleado);
            }
            return empleado;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
