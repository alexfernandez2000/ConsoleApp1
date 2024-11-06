using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model.BBDDConection
{
    public class DalEmploye : BBDDConnection
    {
        public DalEmploye()
        {
            
        }
        public void Update(Job job)
        {
            try
            {
                Conexion();
                string sql = @"UPDATE employees
SET job_title =  @jobTitle,
min_salary = @minSalary,
max_salary = @maxSalary
WHERE job_id = @jobId";
                SqlCommand cmd = new SqlCommand(sql, Connection);
                SqlParameter jobTitle = new SqlParameter("@jobTitle", SqlDbType.VarChar, 35);
                jobTitle.Value = job.job_title;
                SqlParameter minSalary = new SqlParameter("@minSalary", SqlDbType.Decimal);
                minSalary.Value = NullToDBNull(job.min_salary);
                SqlParameter maxSalary = new SqlParameter("@maxSalary", SqlDbType.Decimal);
                maxSalary.Value = NullToDBNull(job.max_salary);
                SqlParameter jobId = new SqlParameter("@jobId", SqlDbType.Int);
                jobId.Value = job.job_id;

                cmd.Parameters.Add(jobTitle);
                cmd.Parameters.Add(minSalary);
                cmd.Parameters.Add(maxSalary);
                cmd.Parameters.Add(jobId);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Desconexion();
            }


        }
        public List<Employe> GetAll ()
        {
            List<Employe> employees = new List<Employe>();
            try
            {
                Conexion();
                string sql = @"SELECT * FROM employees";
                SqlCommand command = new SqlCommand(sql, Connection);
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    Employe employe = new Employe();

                    employe.employee_id = records.GetInt32(0);
                    employe.first_name = records.GetString(1);
                    employe.last_name = records.GetString(2);
                    employe.email = records.GetString(3);
                    employe.phone_number = records.GetString(4);
                    employe.hire_date=records.GetDateTime(5);
                    employe.job_id = records.GetInt32(6);
                    employe.salary = records.GetDecimal(7); 
                    employe.manager_id = records.GetInt32(8);
                    employe.department_id = records.GetInt32(9);
                    employees.Add(employe);
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
            return employees;
        }

    }
}
