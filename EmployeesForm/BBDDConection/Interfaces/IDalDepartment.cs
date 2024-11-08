using System.Collections.Generic;

namespace EmployeesForm.BBDDConection.Interfaces
{
    public interface IDalDepartment 
    {
        List<department> GetAll();
    }
}
