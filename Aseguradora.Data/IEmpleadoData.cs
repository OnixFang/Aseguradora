using Aseguradora.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aseguradora.Data
{
    public interface IEmpleadoData
    {
        Empleado GetAll(List<Empleado> empleados);
        Empleado AddEmpleado(IPersona newEmpleado);
        Empleado UpdateEmpleado(Empleado updatedEmpleado);
        Empleado DeleteEmpleado(Empleado deletedEmpleado);
        int Commit();
    }
}
