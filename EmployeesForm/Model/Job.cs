namespace EmployeesForm.Model
{
    public class Job
    {
        [FormAtributes(false)]
        public int job_id { get; set;}
        public string job_title { get; set; }
        public decimal? min_salary { get; set; }
        public decimal? max_salary { get; set; }
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
