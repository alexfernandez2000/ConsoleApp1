using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using EmployeesForm.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class JobForm : Form
    {
        private DalJob _dalJob;

        public JobForm()
        {
            InitializeComponent();
            _dalJob = new DalJob();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            job job = GetJobData();
            _dalJob.Insert(job);
            RefrescarLista();
        }
        //MostrarLista y modificar jobs
        private void btGetAll_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            dgvJob.DataSource = _dalJob.GetAll();
        }
        private job GetJobData()
        {
            job job = new job();
            job.job_title = tbTitle.Text;
            job.min_salary = decimal.TryParse(tbMinSalary.Text, out decimal minsalary) ? (decimal?)minsalary : null;
            job.max_salary = decimal.TryParse(tbMaxSalary.Text, out decimal maxsalary) ? (decimal?)maxsalary : null;
            return job;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJob.SelectedRows.Count != 0)
            {
                job jobSeleccionado = dgvJob.SelectedRows[0].DataBoundItem as job;
                job jobForm = GetJobData();
                jobSeleccionado.job_title= jobForm.job_title;
                jobSeleccionado.min_salary= jobForm.min_salary;
                jobSeleccionado.max_salary= jobForm.max_salary;
                _dalJob.Update(jobSeleccionado);
                RefrescarLista();
            }
            else
                MessageBox.Show("Select a single job");

        }

        private void dgvJob_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJob.SelectedRows.Count != 0)
            {
                job jobEditar = dgvJob.SelectedRows[0].DataBoundItem as job;
                tbMinSalary.Text = jobEditar.min_salary.ToString();
                tbMaxSalary.Text = jobEditar.max_salary.ToString();
                tbTitle.Text = jobEditar.job_title;
            }
        }
    }
}
