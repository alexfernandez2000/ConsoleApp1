using System;
using System.Collections.Generic;
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
            Conexion();
            try
            {
                string sql = $@"INSERT INTO jobs(job_title,min_salary,max_salary)
                VALUES ('{job.job_title}',{job.min_salary},{job.max_salary})";
                SqlCommand sqlCommand = new SqlCommand(sql,Connection);
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
            Conexion();
            try
            {
                string sql = @"Select * from jobs";
                SqlCommand command = new SqlCommand(sql,Connection);
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    int jobid = records.GetInt32(1);
                    string jobName = records.GetString(2);
                    decimal? minSalary = records.GetDecimal(3);
                    decimal? maxSalary = records.GetDecimal(4);
                    Job job = new Job(jobid,jobName,minSalary,maxSalary);
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
    }
}
