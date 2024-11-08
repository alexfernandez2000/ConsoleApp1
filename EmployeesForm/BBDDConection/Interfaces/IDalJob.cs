using EmployeesForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.BBDDConection.Interfaces
{
    public interface IDalJob
    {
       void Insert(job job);
       List<job> GetAll();
       void Update(job UpdateJob);
    }
}
