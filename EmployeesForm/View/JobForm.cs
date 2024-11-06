using EmployeesForm.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class JobForm : Form
    {
        DalJob jobsData = new DalJob();
        public JobForm()
        {
            InitializeComponent();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Job job = GetJobData();
            jobsData.Insert(job);
        }
        //MostrarLista y modificar jobs
        private void btGetAll_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            dgvJob.DataSource = jobsData.GetAll();
        }
        private Job GetJobData()
        {
            Job job = new Job();
            job.job_title = tbTitle.Text;
            job.min_salary = decimal.TryParse(tbMinSalary.Text, out decimal minsalary) ? (decimal?)minsalary : null;
            job.max_salary = decimal.TryParse(tbMaxSalary.Text, out decimal maxsalary) ? (decimal?)maxsalary : null;
            return job;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJob.SelectedRows.Count != 0)
            {
                Job jobSeleccionado = dgvJob.SelectedRows[0].DataBoundItem as Job;
                Job jobForm = GetJobData();
                jobSeleccionado.job_title= jobForm.job_title;
                jobSeleccionado.min_salary= jobForm.min_salary;
                jobSeleccionado.max_salary= jobForm.max_salary;
                jobsData.Update(jobSeleccionado);
            }
            else
                MessageBox.Show("Select a single job");

        }

        private void dgvJob_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJob.SelectedRows.Count != 0)
            {
                Job jobEditar = dgvJob.SelectedRows[0].DataBoundItem as Job;
                tbMinSalary.Text = jobEditar.min_salary.ToString();
                tbMaxSalary.Text = jobEditar.max_salary.ToString();
                tbTitle.Text = jobEditar.job_title;
            }
        }
    }
}
