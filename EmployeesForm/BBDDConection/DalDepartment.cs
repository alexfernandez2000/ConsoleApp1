using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model.BBDDConection
{
    public class DalDepartment : BBDDConnection,IDalDepartment
    {
        EmployeesDC _dcEmployees;

        public DalDepartment()
        {
            _dcEmployees = new EmployeesDC();
        }
        public List<department> GetAll()
        {
            List<department> departments = new List<department>();
            try
            {
                Conexion();
                departments = _dcEmployees.departments.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Desconexion();
            }
            return departments;
        }

    }
}
