using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model
{
    public class JobsData : BBDDConnection
    {
        public JobsData()
        {

        }
        public void Insert(Job job)
        {
            try
            {
                Conexion();
                string sql = $@"INSERT INTO jobs(job_title,min_salary,max_salary)
                VALUES (@jobTitle,@minSalary,@maxSalary)";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection);
                SqlParameter jobTitle = new SqlParameter("@jobTitle", SqlDbType.VarChar, 35);
                jobTitle.Value = job.job_title;
                SqlParameter minSalary = new SqlParameter("@minSalary", SqlDbType.Decimal);
                minSalary.Value = NullToDBNull(job.min_salary);
                SqlParameter maxSalary = new SqlParameter("@maxSalary", SqlDbType.Decimal);
                maxSalary.Value = NullToDBNull(job.max_salary);

                sqlCommand.Parameters.Add(jobTitle);
                sqlCommand.Parameters.Add(minSalary);
                sqlCommand.Parameters.Add(maxSalary);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Desconexion();
            }
        }
        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                Conexion();
                string sql = @"Select * from jobs";
                SqlCommand command = new SqlCommand(sql, Connection);
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    int jobid = records.GetInt32(0);
                    string jobName = records.GetString(1);
                    decimal? minSalary = records.IsDBNull(2) ? (decimal?)null : records.GetDecimal(2);
                    decimal? maxSalary = records.IsDBNull(3) ? (decimal?)null : records.GetDecimal(3);
                    Job job = new Job(jobid, jobName, minSalary, maxSalary);
                    jobs.Add(job);
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
            return jobs;
        }
        public void Update(Job job)
        {
            try
            {
                Conexion();
                string sql = @"update jobs
set job_title =  @jobTitle,
min_salary = @minSalary,
max_salary = @maxSalary
where job_id = @jobId";
                SqlCommand cmd = new SqlCommand(sql, Connection);
                SqlParameter jobTitle = new SqlParameter("@jobTitle",SqlDbType.VarChar,35);
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
            catch {
                throw;
            }
            finally {
                Desconexion();
            }


        }
    }
}
