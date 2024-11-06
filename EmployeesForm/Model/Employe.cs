using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesForm.Model
{
    public class Employe
    {
     public int employee_id {  get; set; }
     public string first_name { get; set; }
     public string last_name { get; set; }
     public string email { get; set; }
     public string phone_number { get; set; }
     public DateTime hire_date { get; set; }
     public int job_id { get; set; }
     public decimal salary { get; set; }
     public int? manager_id { get; set; }
     public int? department_id { get; set; }
        public Employe()
        {
            
        }

        public Employe(int Employee_id, string First_name, string Last_name, string Email, string Phone_number, DateTime Hire_date, int Job_id, decimal Salary, int? Manager_id, int? Department_id)
        {
            employee_id = Employee_id;
            first_name = First_name;
            last_name = Last_name;
            email = Email;
            phone_number = Phone_number;
            hire_date = Hire_date;
            job_id = Job_id;
            salary = Salary;
            manager_id = Manager_id;
            department_id = Department_id;
        }
    }
}
