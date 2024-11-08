using EmployeesForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.BBDDConection.Interfaces
{
    public interface IDalDepartment 
    {
        List<Department> GetAll();
    }
}
