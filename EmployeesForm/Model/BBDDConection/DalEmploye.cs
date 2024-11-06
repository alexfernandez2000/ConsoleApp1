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
        public void Insert(Employe employe)
        {
            try
            {
                Conexion();
                string sql = @"INSERT INTO employees ([first_name]
           ,[last_name]
           ,[email]
           ,[phone_number]
           ,[hire_date]
           ,[job_id]
           ,[salary]
           ,[manager_id]
           ,[department_id])
   VALUES(@FirstName,@LastName,@Email,@PhoneNumber,@HireDate,@JobId,@Salary,@ManagerId,@DepartmentId)
";
                SqlCommand cmd = new SqlCommand(sql, Connection);
                SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 20);
                firstName.Value = employe.first_name;
                SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.VarChar, 25);
                lastName.Value = employe.last_name;
                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar, 100);
                email.Value = employe.email;
                SqlParameter phoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20);
                phoneNumber.Value = employe.phone_number;
                SqlParameter hireDate = new SqlParameter("@HireDate", SqlDbType.Date, 20);
                hireDate.Value = employe.hire_date;
                SqlParameter jobId = new SqlParameter("@JobId", SqlDbType.Int);
                jobId.Value = employe.job_id;
                SqlParameter salary = new SqlParameter("@Salary", SqlDbType.Decimal);
                salary.Value = employe.salary;
                SqlParameter managerId = new SqlParameter("@ManagerId", SqlDbType.Int);
                managerId.Value = employe.manager_id;
                SqlParameter departmentId = new SqlParameter("@DepartmentId", SqlDbType.Int);
                departmentId.Value = employe.department_id;
                SqlParameter employeeId = new SqlParameter("@EmployeeId", SqlDbType.Int);
                employeeId.Value = employe.employee_id;

                cmd.Parameters.Add(firstName);
                cmd.Parameters.Add(lastName);
                cmd.Parameters.Add(phoneNumber);
                cmd.Parameters.Add(hireDate);
                cmd.Parameters.Add(jobId);
                cmd.Parameters.Add(salary);
                cmd.Parameters.Add(managerId);
                cmd.Parameters.Add(employeeId);
                cmd.Parameters.Add(departmentId);
                cmd.Parameters.Add(employeeId);

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
        public void Update(Employe employe)
        {
            try
            {
                Conexion();
                string sql = @"UPDATE [dbo].[employees]
   SET [first_name] = @FirstName,
      ,[last_name] = @LastName,
      ,[email] = @Email,
      ,[phone_number] = @PhoneNumber,
      ,[hire_date] = @HireDate,
      ,[job_id] = @JobId,
      ,[salary] = @Salary,
      ,[manager_id] = @ManagerId,
      ,[department_id] = @DepartmentId,
 WHERE employee_id = @EmployeeId
";
                SqlCommand cmd = new SqlCommand(sql, Connection);
                SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 20);
                firstName.Value = employe.first_name;
                SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.VarChar, 25);
                lastName.Value = employe.last_name;
                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar, 100);
                email.Value = employe.email;
                SqlParameter phoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20);
                phoneNumber.Value = employe.phone_number;
                SqlParameter hireDate = new SqlParameter("@HireDate", SqlDbType.Date, 20);
                hireDate.Value = employe.hire_date;
                SqlParameter jobId = new SqlParameter("@JobId", SqlDbType.Int);
                jobId.Value = employe.job_id;
                SqlParameter salary = new SqlParameter("@Salary", SqlDbType.Decimal);
                salary.Value = employe.salary;
                SqlParameter managerId = new SqlParameter("@ManagerId", SqlDbType.Int);
                managerId.Value = employe.manager_id;
                SqlParameter departmentId = new SqlParameter("@DepartmentId", SqlDbType.Int);
                departmentId.Value = employe.department_id;
                SqlParameter employeeId = new SqlParameter("@EmployeeId", SqlDbType.Int);
                employeeId.Value = employe.employee_id;

                cmd.Parameters.Add(firstName);
                cmd.Parameters.Add(lastName);
                cmd.Parameters.Add(phoneNumber);
                cmd.Parameters.Add(hireDate);
                cmd.Parameters.Add(jobId);
                cmd.Parameters.Add(salary);
                cmd.Parameters.Add(managerId);
                cmd.Parameters.Add(employeeId);
                cmd.Parameters.Add(departmentId);
                cmd.Parameters.Add(employeeId);

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
                    employe.first_name = records.IsDBNull(1) ? (string)null : records.GetString(1);
                    employe.last_name = records.GetString(2);
                    employe.email = records.GetString(3);
                    employe.phone_number = records.IsDBNull(4) ? (string)null : records.GetString(4); ;
                    employe.hire_date=records.GetDateTime(5);
                    employe.job_id = records.GetInt32(6);
                    employe.salary = records.GetDecimal(7); 
                    employe.manager_id = records.IsDBNull(8) ? (int?)null : records.GetInt32(8);
                    employe.department_id = records.IsDBNull(9) ? (int?)null : records.GetInt32(9);
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
