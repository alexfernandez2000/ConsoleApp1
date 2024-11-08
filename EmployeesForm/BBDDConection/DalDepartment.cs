using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model.BBDDConection
{
    public class DalDepartment : BBDDConnection
    {
        public DalDepartment()
        {
            
        }
        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            try
            {
                Conexion();
                string sql = @"SELECT * FROM departments";
                SqlCommand command = new SqlCommand(sql, Connection);
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    int departmentId = records.GetInt32(0);
                    string departmentName = records.GetString(1);
                    int? locationId = records.IsDBNull(2) ? (int?)null : records.GetInt32(2);
                    Department department = new Department(departmentId,departmentName,locationId);
                    departments.Add(department);
                }

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
