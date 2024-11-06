using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model
{
    public class Department
    {
      public int department_id { get; set; }
      public string department_name { get; set; }
      public int? location_id { get; set; }
        public Department()
        {
            
        }

        public Department(int Department_id, string Department_name, int? Location_id)
        {
            department_id = Department_id;
            department_name = Department_name;
            location_id = Location_id;
        }
    }
}
