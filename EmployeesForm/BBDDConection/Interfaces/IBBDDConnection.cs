using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.BBDDConection.Interfaces
{
    public interface IBBDDConnection
    {
       void Conexion();
       void Desconexion();
       object NullToDBNull(object value);
    }
}
