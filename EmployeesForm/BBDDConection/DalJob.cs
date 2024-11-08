using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model
{
    public class DalJob : BBDDConnection,IDalJob
    {
        EmployeesDC _dc;
        public DalJob()
        {
            _dc = new EmployeesDC();
        }
        public void GetByIdDBContext(int id)
        {
            var jobs = _dc.jobs.Where(x => x.job_id == id).ToList();
            _dc.jobs.InsertOnSubmit(jobs.FirstOrDefault());
            //_pruebasDataContext.SubmitChanges();
        }
        public void Insert(job job)
        {
            try
            {
                _dc.Connection.Open();
                _dc.jobs.InsertOnSubmit(job);
                _dc.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _dc.Connection.Close();
            }
        }
        public List<job> GetAll()
        {
            List<job> jobs = new List<job>();
            try
            {
                _dc.Connection.Open();
                jobs=_dc.jobs.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _dc.Connection.Close();
            }

            return jobs;
        }
        public void Update(job UpdateJob)
        {
            List<job> jobs = new List<job>();
            try
            {
                _dc.Connection.Open();
                job job= _dc.jobs.Where(x=> x.job_id== UpdateJob.job_id).FirstOrDefault();
                job = UpdateJob;
                _dc.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _dc.Connection.Close();
            }
        }
    }
}
