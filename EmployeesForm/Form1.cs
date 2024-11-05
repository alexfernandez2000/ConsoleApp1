using EmployeesForm.Model;
using System;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            decimal? minSalary = decimal.TryParse(tbMinSalary.Text, out decimal minsalary) ? (decimal?)minsalary : null ;
            decimal? maxSalary = decimal.TryParse(tbMaxSalary.Text, out decimal maxsalary) ? (decimal?)maxsalary : null;
            Job job = new Job(title,minSalary,maxSalary);
            JobsData jobsData = new JobsData(); 
            jobsData.Insert(job);
        }
    }
}
