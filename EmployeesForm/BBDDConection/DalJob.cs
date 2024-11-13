using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EmployeesForm.Model
{
    public class DalJob : BBDDConnection,IDalJob
    {
        public DalJob()
        {
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
                Conexion();
                _dc.jobs.InsertOnSubmit(job);
                _dc.SubmitChanges();
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
        public List<job> GetAll()
        {
            List<job> jobs = new List<job>();
            try
            {
                Conexion();
                jobs=_dc.jobs.ToList();
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
        public void Update(job UpdateJob)
        {
            try
            {
                Conexion();
                job job= _dc.jobs.Where(x=> x.job_id== UpdateJob.job_id).FirstOrDefault();
                if (job == null)
                    return;

                job = UpdateJob;
                _dc.SubmitChanges();
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
    }
}
