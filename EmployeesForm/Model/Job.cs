namespace EmployeesForm.Model
{
    public class Job
    {
        public int job_id;
        public string job_title;
        public decimal? min_salary;
        public decimal? max_salary;
        public Job()
        {
            
        }
        public Job(string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            job_title = jobTitle;
            min_salary = minSalary;
            max_salary = maxSalary;
        }

        public Job(int jobid,string jobTitle,decimal? minSalary,decimal? maxSalary)
        {
            job_id = jobid;
            job_title = jobTitle;
            min_salary = minSalary;
            max_salary = maxSalary;
        }
    }
}
