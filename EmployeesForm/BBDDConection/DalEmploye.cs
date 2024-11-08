using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace EmployeesForm.Model.BBDDConection
{
    public class DalEmploye : BBDDConnection,IDalEmploye
    {
        public DalEmploye()
        {
            
        }
        public void Insert(employee employe)
        {
            try
            {
                Conexion();
                _dc.employees.InsertOnSubmit(employe);
                _dc.SubmitChanges();
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
        public void Update(employee Employe)
        {
            try
            {
                Conexion();
                employee employe = _dc.employees.Where(x=>x.employee_id == Employe.employee_id).FirstOrDefault();
                if (employe == null)
                    return;
                employe = Employe;

                _dc.SubmitChanges();
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
        public List<employee> GetAll ()
        {
            List<employee> employees = new List<employee>();
            try
            {
                Conexion();
                employees = _dc.employees.ToList();
                
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
